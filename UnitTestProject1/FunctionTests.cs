using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FunctionTests
    {
        [TestMethod]
        public void cheeckIfPossible_ExpectedBehaviour(int number,string number2)
        {
            ///Arrange
            int secondNumber = int.Parse(number2);
            bool truth = false;
            ///


            ///Act
            if (number - secondNumber >= 0)
                truth = true;
            ///

            ///Assert
            Assert.IsTrue(truth);
            ///

        }
    }
}
