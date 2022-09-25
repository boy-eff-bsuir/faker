using System;
using System.Collections.Generic;
using Faker.Core;
using Faker.Core.Services;
using Faker.Tests.Fakes;
using Xunit;

namespace Faker.Tests
{
    public class FakerTests
    {
        [Fact]
        public void GeneratorsDictionaryShouldNotBeEmpty()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<Struct>();
            Assert.NotNull(result);
        }
    }
}