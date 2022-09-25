using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faker.Core.Interfaces
{
    public interface IValueGenerator
    {
        object Generate(Type typeToGenerate, IGeneratorContext context);
        bool CanGenerate(Type t);
    }
}