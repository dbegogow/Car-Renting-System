using Xunit;
using CarRentingSystem.Test.Mocks;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Services.Dealers;

namespace CarRentingSystem.Test.Services
{
    public class DealerServiceTest
    {
        private const string UserId = "TestUserId";

        [Fact]
        public void IsDealerShouldReturnTrueWhenUserIsDealer()
        {
            // Arrange
            var dealerService = GetDealerService();

            // Act
            var result = dealerService.IsDealer(UserId);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsDealerShouldReturnFalseWhenUserIsNotDealer()
        {
            // Arrange
            const string anotherUserId = "anotherUserId";

            var dealerService = GetDealerService();

            // Act
            var result = dealerService.IsDealer(anotherUserId);

            // Assert
            Assert.False(result);
        }

        private static IDealerService GetDealerService()
        {
            var data = DatabaseMock.Instance;

            data.Dealers.Add(new Dealer { UserId = UserId });
            data.SaveChanges();

            return new DealerService(data);
        }
    }
}
