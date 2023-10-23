using Calculadora.Services;
using Microsoft.AspNetCore.Mvc.Testing;

namespace CalculadoraTestes
{
    public class CalculadoraTestes
    {
        private Calculator obj;

        public CalculadoraTestes()
        {
            obj = new Calculator();
        }
        //Give-When-Then
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 4, 6)]
        public void GiveTwoIntergesNumbersToSumThenSuccess(int num1, int num2, int result)
        {
            //Action
            var resultMethod = obj.Sum(num1, num2);
            //Assert
            Assert.Equal(result, resultMethod);
        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(5, 1, 4)]
        public void GiveTwoIntergesNumbersToSubtractThenSuccess(int num1, int num2, int result)
        {
            //Action
            var resultMethod = obj.Subtract(num1, num2);
            //Assert
            Assert.Equal(result, resultMethod);
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 4, 6)]
        public void GiveTwoIntergesNumbersToDivideThenSuccess(int num1, int num2, int result)
        {
            //Action
            var resultMethod = obj.Divide(num1, num2);
            //Assert
            Assert.Equal(result, resultMethod);
        }
        [Fact]
        public void GiveOneIntergeNumberToDivideByZeroThenResultEqualsZeroSuccess()
        {
            //Action
            var resultMethod = obj.Divide(5, 0);
            //Assert
            Assert.Equal(0, resultMethod);
        }

        [Theory]
        [InlineData(6, 2, 12)]
        [InlineData(2, 4, 8)]
        public void GiveTwoIntergesNumbersToMultiplyThenSuccess(int num1, int num2, int result)
        {
            //Action
            var resultMethod = obj.Multiply(num1, num2);
            //Assert
            Assert.Equal(result, resultMethod);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        public void GiveIntegerCreateLogsToCountThenSuccess(int num1)
        {
            for (int i = 0; i < num1; i++)
            {
                RandomCallMethod();
            }
            var resultMethod = obj.GetLogs(num1);
            //Assert
            Assert.Equal(num1, resultMethod.Count());
        }

        private void RandomCallMethod()
        {
            var random = new Random().Next(0, 3);
            var randomNum1 = new Random().Next(0, 1500);
            var randomNum2 = new Random().Next(0, 1000);
            switch (random)
            {
                case 0:
                    _ = obj.Sum(randomNum1, randomNum2);
                    break;

                case 1:
                    _ = obj.Divide(randomNum1, randomNum2);
                    break;

                case 2:
                    _ = obj.Multiply(randomNum1, randomNum2);
                    break;

                case 3:
                    _ = obj.Subtract(randomNum1, randomNum2);
                    break;
            }
        }
    }
}