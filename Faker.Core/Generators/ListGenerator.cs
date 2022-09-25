using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class ListGenerator : IValueGenerator
    {
        public bool CanGenerate(Type t)
        {
            if (t.IsGenericType)
            {
                return t.GetGenericTypeDefinition() == typeof(List<>);
            }
            return false;
        }
        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            var argument = typeToGenerate.GetGenericArguments().First();
            var generic = typeof(List<>).MakeGenericType(argument);
            MethodInfo method = typeof(Faker).GetMethod("Create")
                             .MakeGenericMethod(new Type[] { argument });
            var result = method.Invoke(context.Faker, new object[] {});
            var list = Activator.CreateInstance(generic);
            var addMethod = generic.GetMethod("Add");
            addMethod.Invoke(list, new object[] {result});
            return list;
        }
    }
}