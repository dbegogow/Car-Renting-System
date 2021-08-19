using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;

namespace CarRentingSystem.Test.Controller
{
    public class HomeControllerSystemTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;

        public HomeControllerSystemTest(WebApplicationFactory<Startup> factory)
            => this.factory = factory;

        [Fact]
        public async Task IndexShouldReturnCorrectResult()
        {
            // Arrange
            var client = this.factory.CreateClient();

            // Act
            var result = await client.GetAsync("/");

            // Assert
            Assert.True(result.IsSuccessStatusCode);
        }
    }
}
