using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class DoubleGenerator : IValueGenerator
    {
        public bool CanGenerate(Type t)
        {
            return t == typeof(double);
        }

        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            var result = context.Random.Next() + context.Random.NextDouble();
            return result;
        }
    }
}