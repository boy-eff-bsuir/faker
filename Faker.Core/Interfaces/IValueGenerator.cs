using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faker.Core.Interfaces
{
    public interface IValueGenerator
    {
        bool CanGenerate(Type t);
        object Generate(Type typeToGenerate, IGeneratorContext context);
    }
}