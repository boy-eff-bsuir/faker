using System;
using System.Collections.Generic;
using Xunit;

namespace Faker.Tests
{
    public class FakerTests
    {
        [Fact]
        public void GeneratorsDictionaryShouldNotBeEmpty()
        {
            Core.Faker sut = new Core.Faker();
            var result = sut.Create<List<List<string>>>();
            Assert.NotNull(result);
        }
    }
}