using System.Runtime.Intrinsics.X86;

namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Fact]
        public void TwoNumbersAreNotEqual()
        {
            // arrange
            float number1 = 566.3f;
            float number2 = 655.4f;
            // act
            

            // assert
            Assert.NotEqual(number1, number2);
        }
        [Fact]
        public void TwoNumbersAreEqual()
        {
            // arrange
            int number1 = 5;
            int number2 = 5;

            // act


            // assert
            Assert.Equal(number1, number2);
        }
        [Fact]
        public void TwoNamesAreEqual()
        {
            // arrange
            string name1 = "Kamil";
            string name2 = "Kamil";
            

            // act


            // assert
            Assert.Equal(name1, name2);
        }
        [Fact]
        public void TEST1()
        {
            // arrange
            var user1 = new User("Adam");
            var user2 = new User("Adam");

            // act


            // assert
            Assert.Equal(user1.Login, user2.Login);
        }
        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
