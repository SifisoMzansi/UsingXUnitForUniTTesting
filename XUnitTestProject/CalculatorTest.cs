
namespace XUnitLibrary.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            //Arrange
            double Expected = 5;

            //Act
            double Actual = Calculator.Add(3, 2);
            
            //Assert
            Assert.Equal(Expected, Actual); 
        }
        [Theory]
         [InlineData(0, 5)]
        public void Add_SimpleValuesShouldFail(double count1, double count2)
        {
            //Arrange
            double Expected = 5;

            //Act
            double Actual = Calculator.Add(count1, count2);

            //Assert
            Assert.Equal(Expected, Actual);
        }

    }
}