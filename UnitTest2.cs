using RemoveAuction;
using System.Security.Cryptography.X509Certificates;

namespace AuctionsTest
{
    public class UnitTest2
    {
        [Fact]
        public void Test2()
        {
            //arrange
            int BidCount = 0;

            //Act
            RemoveAuction tryRemove = new RemoveAuction();
            bool tryRemoveResult = tryRemove.tryRemoveAuction(BidCount);

            //Assert
            Assert.True(tryRemoveResult);
        }
    }
}