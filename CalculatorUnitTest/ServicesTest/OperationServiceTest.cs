using Calculator.Services;
using NUnit.Framework;

namespace CalculatorUnitTest.ServicesTest
{
    public class OperationServiceTest
    {
        OperationService service = new OperationService();
        
        [Test]
        public void ShouldReturnAdditionResultAfterOperationIfOperatorIsAddition()
        {
            //Given
            double operand1 = 1.5;
            double operand2 = 1.5;
            double expectedResult = 3.0;
            
            //Act
            var actualResult = service.Operation(operand1, operand2, 1);
            
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void ShouldReturnSubtractionResultAfterOperationIfOperatorIsMinus()
        {
            //Given
            double operand1 = 2.0;
            double operand2 = 1.5;
            double expectedResult = 0.5;
            
            //Act
            var actualResult = service.Operation(operand1, operand2, 2);
            
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void ShouldReturnMultiplicationResultAfterOperationIfOperatorIsMultiply()
        {
            //Given
            double operand1 = 2.0;
            double operand2 = 1.5;
            double expectedResult = 3.0;
            
            //Act
            var actualResult = service.Operation(operand1, operand2, 3);
            
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void ShouldReturnDivisionResultAfterOperationIfOperatorIsDivide()
        {
            //Given
            double operand1 = 2.0;
            double operand2 = 0.5;
            double expectedResult = 4.0;
            
            //Act
            var actualResult = service.Operation(operand1, operand2, 4);
            
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}