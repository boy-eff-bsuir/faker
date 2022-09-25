using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class DateTimeGenerator : IValueGenerator
    {
        private int _initYear = 1990;
        private int _initMonth = 1;
        private int _initDay = 1;
        private int _maxDays = 10000;
        private int _maxSeconds = 10000;

        public bool CanGenerate(Type t)
        {
            return t == typeof(DateTime);
        }


        public object Generate(Type typeToGenerate, IGeneratorContext context)
        {
            DateTime dateTime = new DateTime(_initYear, _initMonth, _initDay);
            var days = context.Random.Next(_maxDays);
            var seconds = context.Random.Next(_maxSeconds);
            var result = dateTime.AddDays(days).AddSeconds(seconds);
            return result;
        }
    }
}