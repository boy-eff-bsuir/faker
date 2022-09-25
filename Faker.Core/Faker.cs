using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core
{
    public class Faker : IFaker
    {
        private List<IValueGenerator> _generators;
        private IGeneratorContext _context;

        public Faker()
        {
            _generators = new List<IValueGenerator>();
            InitializeGenerators();
            _context = new GeneratorContext(new Random(), this);
        }

        public T Create<T>()
        {
            var type = typeof(T);
            var generator = _generators.SingleOrDefault(x => x.CanGenerate(type));
            if (generator == null)
            {
                throw new Exception("Generator is not found");
            }
            var result = generator.Generate(type, _context);
            return (T) result;
        }

        private void InitializeGenerators()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.IsAssignableTo(typeof(IValueGenerator)) && type.IsClass)
                {
                    var generator = Activator.CreateInstance(type);
                    _generators.Add((IValueGenerator)generator);
                }
            }
        }
    }
}