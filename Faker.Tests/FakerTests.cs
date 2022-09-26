using System;
using System.Collections.Generic;
using Faker.Core;
using Faker.Core.Services;
using Faker.Tests.Fakes;
using FluentAssertions;
using Xunit;

namespace Faker.Tests
{
    public class FakerTests
    {
        [Fact]
        public void ByteGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<byte>();
            result.Should().NotBe(default);
        }

        [Fact]
        public void CharGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<char>();
            result.Should().NotBe(default);
        }

        [Fact]
        public void DateTimeGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<DateTime>();
            result.Should().NotBe(default);
        }

        [Fact]
        public void DecimalGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<decimal>();
            result.Should().NotBe(default);
        }

        [Fact]
        public void DoubleGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<double>();
            result.Should().NotBe(default);
        }

        [Fact]
        public void FloatGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<float>();
            result.Should().NotBe(default);
        }

        [Fact]
        public void IntegerGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<int>();
            result.Should().NotBe(default);
        }

        [Fact]
        public void ListGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<List<string>>();
            result.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void LongGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<long>();
            result.Should().NotBe(default);
        }

        [Fact]
        public void ShortGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<short>();
            result.Should().NotBe(default);
        }

        [Fact]
        public void SignedByteGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<sbyte>();
            result.Should().NotBe(default);
        }

        [Fact]
        public void StringGeneratorShouldReturnNotDefault()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<string>();
            result.Should().NotBe(default);
        }
    }
}