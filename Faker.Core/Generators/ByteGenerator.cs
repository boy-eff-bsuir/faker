using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class ByteGenerator : IValueGenerator
    {
        public bool CanGenerate(Type t)
        {
            return t == typeof(byte);
        }

        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            byte result = (byte)context.Random.Next(256);
            return result;
        }
    }
}