using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Tests.Generators
{
    public class NameGenerator : IValueGenerator
    {
        public bool CanGenerate(Type t)
        {
            return t == typeof(string);
        }

        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            return "Danila";
        }
    }
}