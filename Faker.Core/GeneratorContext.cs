using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core
{
    public class GeneratorContext : IGeneratorContext
    {
        public GeneratorContext(Random random, IFaker faker)
        {
            this.Random = random;
            Faker = faker;
        }
        
        public string Alphabet {get;} = "abcdefghijklmnopqrstuvwxyz";
        public Random Random { get; }
        public IFaker Faker { get; }
    }
}