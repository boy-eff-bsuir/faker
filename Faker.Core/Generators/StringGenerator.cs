using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class StringGenerator : IValueGenerator
    {
        private string _alphabet = "abcdefghijklmnopqrstuvwxyz";
        private int _minLength = 10;
        private int _maxLength = 32;
        
        public bool CanGenerate(Type t)
        {
            return t == typeof(string);
        }


        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            var len = context.Random.Next(_minLength, _maxLength);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                var index = context.Random.Next(_alphabet.Length);
                sb.Append(_alphabet[index]);
            }
            return  sb.ToString();
        }
    }
}