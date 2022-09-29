using System;
using System.Collections.Generic;
using Faker.Core;
using Faker.Core.Configuration;
using Faker.Core.Services;
using Faker.Tests.Fakes;
using Faker.Tests.Generators;
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

        [Fact]
        public void ShouldFakeUserType()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<Class>();
            result.Should().NotBeNull();
            result.FirstName.Should().NotBeNullOrEmpty();
            result.Age.Should().BeGreaterThan(0);
            result.Children.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void ShouldAvoidCyclicDependency()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<ClassWithCyclicDependency>();
            result.Should().NotBeNull();
            result.FirstName.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void ShouldNotGeneratePrivateSetters()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<ClassWithPrivateSetter>();
            result.Should().NotBeNull();
            result.PrivateProperty.Should().Be(default);
        }

        [Fact]
        public void ShouldUseConstructorWithMoreParams()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<ClassWithConstructor>();
            result.Should().NotBeNull();
            result.PrivateProperty.Should().NotBe(default);
        }

        [Fact]
        public void ShouldUseDifferentConstructors()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<ClassWithBrokenConstructor>();
            result.Should().NotBeNull();
            result.Prop1.Should().NotBe(default);
            result.Prop2.Should().Be(default);
        }

        [Fact]
        public void ShouldUseGeneratorFromConfig()
        {
            var config = new GeneratorConfig();
            config.Add<Class, string, NameGenerator>(u => u.FirstName);
            var generatorService = new GeneratorService(config);
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<Class>();
            result.Should().NotBe(default);
            result.FirstName.Should().Be("Danila");
            result.LastName.Should().NotBe("Danila");
        }

        [Fact]
        public void ShouldUseGeneratorFromConfigUsingConstructor()
        {
            var config = new GeneratorConfig();
            config.Add<ClassWithConstructor, string, NameGenerator>(u => u.PrivateProperty);
            var generatorService = new GeneratorService(config);
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<ClassWithConstructor>();
            result.Should().NotBe(default);
            result.PrivateProperty.Should().Be("Danila");
        }

        [Fact]
        public void ShouldFakeUserTypeWithRussianProperty()
        {
            var generatorService = new GeneratorService();
            var cycleResolveService = new CycleResolveService();
            Core.Faker sut = new Core.Faker(generatorService, cycleResolveService);
            var result = sut.Create<ClassWithRussianProperty>();
            result.Should().NotBeNull();
            result.FirstName.Should().NotBeNullOrEmpty();
            result.Age.Should().BeGreaterThan(0);
            result.Children.Should().NotBeNullOrEmpty();
            result.Возраст.Should().BeGreaterThan(0);
        }
    }
}