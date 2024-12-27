namespace ChallangeApp.Tests
{
    public class UnitTest
    {
        [Fact]
        public void WhenUserCollectSevenSetOfPoints_ShouldCorrectResult1()
        {
            // arrange
            var user = new User("Adam", "Dupa");
            user.AddGrade(5);
            user.AddGrade(6);
            // act
            var result = user.Result;

            // assert
            Assert.Equal(11, result);
        }
    }
}
