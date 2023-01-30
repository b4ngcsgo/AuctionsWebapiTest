using RemoveAuction;
using System.Security.Cryptography.X509Certificates;

namespace AuctionsTest
{
    public class UnitTest3
    {
        [Fact]
        public void Test3()
        {
            //arrange
            int bidUserID = 1;
            int auctionOwnerUserID = 1;

            //Act
            PlaceBid bid = new PlaceBid();
            bool tryBidResult = bid.tryPlaceBid(bidUserID, auctionOwnerUserID);

            //Assert
            Assert.True(tryRemoveResult);
        }
    }
}