using Xunit;
using RestaurantModels;

namespace RestaurantTest;

public class ModelsTest
{
    [Fact]
    public void PPShouldBevalidData()
    {
        //Arrange
        var RestaurantReviews = new RestaurantReviews();
        int validRating = 10;
        //Act
        RestaurantReviews.Rating = validRating;
        //Assert
        Assert.Equal(validRating, RestaurantReviews.Rating); //checks if the property does indeed hold the same value as what we set it as
    }

    [Theory]
    [InlineData(-10)]
    [InlineData(-120)]
    [InlineData(-123445)]
    public void PPShouldSetValidData(int r_invalidData)
    {
        //Arrange
        var ab = new RestaurantReviews();

        //Assert
        Assert.Throws<System.Exception>(
            () => ab.Rating = r_invalidData
            );
    }
}
