using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faker.Tests.Fakes
{
    public class ClassWithConstructor : Class
    {
        public int PrivateProperty { get; }
        public ClassWithConstructor(int privateProp)
        {
            PrivateProperty = privateProp;
        }
    }
}