using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Faker.Core.Exceptions;
using Faker.Core.Interfaces;

namespace Faker.Core.Services
{
    public class GeneratorService : IGeneratorService
    {
        private List<IValueGenerator> _generators;

        public GeneratorService()
        {
            InitializeGenerators();
        }

        public object Generate(Type type, IGeneratorContext context)
        {
            var generator = _generators.SingleOrDefault(x => x.CanGenerate(type));
            if (generator == null)
            {
                throw new UnsupportedTypeException();
            }
            var result = generator.Generate(type, context);
            return result;
        }

        private void InitializeGenerators()
        {
            _generators = new List<IValueGenerator>();
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