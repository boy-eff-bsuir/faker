using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class BooleanGenerator : IValueGenerator
    {
        public bool CanGenerate(Type t)
        {
            return t == typeof(bool);
        }

        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            bool result = false;
            var rand = context.Random.NextInt64(2);
            result = Convert.ToBoolean(rand);
            return result;
        }
    }
}