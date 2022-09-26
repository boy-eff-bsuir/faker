using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class SignedByteGenerator : IValueGenerator
    {
        public bool CanGenerate(Type t)
        {
            return t == typeof(sbyte);
        }

        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            var result = (sbyte)context.Random.Next(256);
            return result;
        }
    }
}