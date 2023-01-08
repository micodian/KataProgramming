using TDDProgramming.Kata;

namespace TDDProgramingTest.Tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        private StringCalculator? _stringCalculator;
        [TestInitialize]
        public void SetUp()
        {
            _stringCalculator = new StringCalculator();
        }

        [TestMethod]
        public void StringCalculator_Should_Be_Initialized()
        {
            Assert.IsNotNull(_stringCalculator);
        }

        [TestMethod]
        public void StringCalculator_Add_Method_Should_Return_0_For_Empty_Input()
        {
            //Arrange
            string input = "";
            //Act
            var result = _stringCalculator?.Add(input);
            //Assert
            Assert.AreEqual(0, result);
        }


        [TestMethod]
        public void StringCalculator_Add_Method_Should_Return_For_Single_Input()
        {
            //Arrange
            string input = "1";
            //Act
            var result = _stringCalculator?.Add(input);
            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void StringCalculator_Add_Method_Should_Return_For_Two_Numbers()
        {
            //Arrange
            string input = "1,2";
            //Act
            var result = _stringCalculator?.Add(input);
            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void StringCalculator_Add_Method_Should_Return_For_Multiple_Numbers()
        {
            //Arrange
            string input = "1,2,3,4,5,6,7";
            //Act
            var result = _stringCalculator?.Add(input);
            //Assert
            Assert.AreEqual(28, result);
        }

        [TestMethod]
        public void StringCalculator_Add_Method_Should_Return_Using_NewLine_Delimeter()
        {
            //Arrange
            string input = "1\n2,3";
            //Act
            var result = _stringCalculator?.Add(input);
            //Assert
            Assert.AreEqual(6, result);
            
        }

        [TestMethod]
        public void StringCalculator_Add_Method_Should_Return_While_Supporting_Different_Delimeters()
        {
            //Arrange
            string input = "//;\n1;2";
            //Act
            var result = _stringCalculator?.Add(input);
            //Assert
            Assert.AreEqual(3, result);            
        }
    }
}