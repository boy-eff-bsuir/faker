using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faker.Tests.Fakes
{
    public class User
    {
        public User(string name, byte age, List<string> children)
        {
            Name = name;
            Age = age;
            Children = children;
        }

        public string Name { get; set; }
        public byte Age { get; set; }
        public List<string> Children { get; set; }
        public User Kotakbas { get; set; }
    }
}