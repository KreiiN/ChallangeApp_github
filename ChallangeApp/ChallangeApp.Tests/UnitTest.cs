namespace ChallangeApp.Tests
{
    public class UnitTest
    {
        [Fact]
        public void WhenUserCollectSevenSetOfPoints_ShouldCorrectResult1()
        {
            // arrange
            var user = new User("Adam", "Dupa");
            user.AddGrade(9);
            user.AddGrade(9);
            user.AddGrade(9);
            user.AddGrade(1);
            user.AddGrade(1);
            user.AddGrade(1);
            user.AddGrade(-7);
            // act
            var result = user.Result;

            // assert
            Assert.Equal(23, result);
        }

        [Fact]
        public void WhenUserCollectSevenSetOfPoints_ShouldCorrectResult2()
        {
            // arrange
            var user = new User("Adam", "Dupczykowski");
            user.AddGrade(5);
            user.AddGrade(8);
            user.AddGrade(3);
            user.AddGrade(9);
            user.AddGrade(-2);
            user.AddGrade(-3);
            user.AddGrade(-5);
            // act
            var result = user.Result;

            // assert
            Assert.Equal(15, result);
        }
        [Fact]
        public void WhenUserCollectEightSetOfPoints_ShouldCorrectResult3()
        {
            // arrange
            var user = new User("Adam", "Ruchamspadam");
            user.AddGrade(5);
            user.AddGrade(6);
            user.AddGrade(7);
            user.AddGrade(2);
            user.AddGrade(4);
            user.AddGrade(-9);
            user.AddGrade(-4);
            user.AddGrade(-3);
            // act
            var result = user.Result;

            // assert
            Assert.Equal(8, result);
        }
    }
}
