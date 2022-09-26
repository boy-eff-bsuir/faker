using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class FloatGenerator : IValueGenerator
    {
        public bool CanGenerate(Type t)
        {
            return t == typeof(float);
        }

        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            var result = (float)(context.Random.Next() + context.Random.NextDouble());
            return result; 
        }
    }
}