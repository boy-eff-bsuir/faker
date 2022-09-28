using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Faker.Core.Interfaces
{
    public interface IGeneratorConfig
    {
        void Add<A, B, C>(Expression<Func<A, B>> expression) where C : IValueGenerator;
        IValueGenerator GetGeneratorByName(string name);
    }
}