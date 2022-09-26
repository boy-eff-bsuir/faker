using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class LongGenerator : IValueGenerator
    {
        public bool CanGenerate(Type t)
        {
            return t == typeof(long);
        }

        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            var result = context.Random.NextInt64();
            return result;
        }
    }
}