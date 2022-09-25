using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faker.Core.Interfaces
{
    public interface IGeneratorContext
    {
        Random Random { get; }
        IFaker Faker { get; }

    }
}