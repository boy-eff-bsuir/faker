using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Faker.Core.Exceptions;
using Faker.Core.Interfaces;

namespace Faker.Core
{
    public class Faker : IFaker
    {  
        private IGeneratorService _generatorService;
        private List<Type> _usedTypes;
        private IGeneratorContext _context;
        public Faker(IGeneratorService generatorService)
        {
            _generatorService = generatorService;
            _usedTypes = new List<Type>();
            _context = new GeneratorContext(new Random(), this);
        }

        public T Create<T>()
        {
            var type = typeof(T);
            return (T) Create(type);
        }

        private object Create(Type t) 
        {
            try
            {
                var result = _generatorService.Generate(t, _context);
                return result;
            }
            catch(UnsupportedTypeException)
            {
                var obj = InitializeUserType(t);
                InitializeFields(obj);
                InitializeProperties(obj);
                return obj;
            }
        }

         private object InitializeUserType(Type type)
         {
            var ctors = type.GetConstructors()
                .OrderByDescending(x => x.GetParameters().Count());
            foreach (var ctor in ctors)
            {
                try
                {
                    var result = InitializeUserTypeViaConstructor(ctor);
                    return result;
                }
                catch
                {
                    System.Console.WriteLine("Exception while initializing type");
                }
            }
            return null;
         }

         private object InitializeUserTypeViaConstructor(ConstructorInfo ctor)
         {
            var parameters = ctor.GetParameters();
            var initParameters = new List<object>();
            foreach(var param in parameters)
            {
                if (IsCyclic(param.ParameterType))
                {
                    initParameters.Add(null);
                }
                else
                {
                    _usedTypes.Add(param.ParameterType);
                    var initializedParam = Create(param.ParameterType);
                    _usedTypes.Remove(param.ParameterType);
                    initParameters.Add(initializedParam);
                }
            }
            var result = ctor.Invoke(initParameters.ToArray());
            return result;
         }

         private void InitializeFields(object obj)
         {
            var type = obj.GetType();
            var fields = type.GetFields();
            foreach (var field in fields)
            {
                if(IsCyclic(field.FieldType))
                {
                    field.SetValue(obj, null);
                }
                else
                {
                    _usedTypes.Add(field.FieldType);
                    var result = Create(field.FieldType);
                    _usedTypes.Remove(field.FieldType);
                    field.SetValue(obj, result);
                }
            }
         }

         private void InitializeProperties(object obj)
         {
            var type = obj.GetType();
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                if(IsCyclic(prop.PropertyType))
                {
                    prop.SetValue(obj, null);
                }
                else 
                {
                    _usedTypes.Add(prop.PropertyType);
                    var result = Create(prop.PropertyType);
                    _usedTypes.Remove(prop.PropertyType);
                    prop.SetValue(obj, result);
                }
            }
         }

         private bool IsCyclic(Type t)
         {
            return _usedTypes.Contains(t);
         }
    }
}