using Xunit;

namespace RestaurantReviewTest
{
    public class TestDummyForTest
    {
        
        [Fact]
        public void TestAdd()
        {
            //Arrange
            TestDummyForTest obj=new TestDummyForTest();
            //Act

            //Assert
            Assert.Equal(obj, obj);

        }
    }
}