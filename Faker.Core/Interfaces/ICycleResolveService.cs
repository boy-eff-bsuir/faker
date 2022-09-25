using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faker.Core.Interfaces
{
    public interface ICycleResolveService
    {
        bool Contains(Type t);
        void Add(Type t);
        void Remove(Type t);
        void Clear();
    }
}