using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class DecimalGenerator : IValueGenerator
    {
        public bool CanGenerate(Type t)
        {
            return t == typeof(decimal);
        }

        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            var result = (decimal)(context.Random.NextInt64() + context.Random.NextDouble());
            return result;
        }
    }
}