using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faker.Core.Interfaces
{
    public interface IGeneratorService
    {
        object Generate(Type type, IGeneratorContext context, string name = null);
    }
}