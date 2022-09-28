using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faker.Tests.Fakes
{
    public class ClassWithConstructor : Class
    {
        public string PrivateProperty { get; }
        public ClassWithConstructor(string privateProperty)
        {
            PrivateProperty = privateProperty;
        }
    }
}