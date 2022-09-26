using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faker.Tests.Fakes
{
    public class ClassWithCyclicDependency : Class
    {
        public ClassWithCyclicDependency Child { get; set; }
    }
}