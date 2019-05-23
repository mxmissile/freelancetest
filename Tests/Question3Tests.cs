using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using NUnit.Framework;
using Tests.TestingStuff;
using WebApp.App.Question3;

namespace Tests
{
    public class Question3Tests
    {
        private TestDependencyResolver _serviceProvider;

        [SetUp]
        public void Setup()
        {
            var webHost = WebHost.CreateDefaultBuilder()
                .UseStartup("WebApp")
                .Build();
            _serviceProvider = new TestDependencyResolver(webHost);
        }

        [Test]
        public void Loader_loads()
        {
            // act
            var sut = _serviceProvider.GetService<PrescriptionLoader>();

            // assert
            Assert.NotNull(sut);
        }

        [Test]
        public void Loader_uses_WalgreensPrescription()
        {
            // act
            var sut = _serviceProvider.GetService<PrescriptionLoader>();

            // assert
            Assert.True(sut.Prescription is WalgreensPrescription);
        }

        [Test]
        public async Task FillPrescription_fills_prescription()
        {
            // arrange
            var sut = _serviceProvider.GetService<PrescriptionLoader>();

            // act
            var result = await sut.Load();

            // assert
            Assert.True(result);
        }
    }
}
