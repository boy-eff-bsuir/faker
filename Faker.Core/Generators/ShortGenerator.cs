using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class ShortGenerator : IValueGenerator
    {
        private int _maxValue = 32768;
        public bool CanGenerate(Type t)
        {
            return t == typeof(short);
        }

        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            var result = context.Random.Next(_maxValue);
            return result;
        }
    }
}