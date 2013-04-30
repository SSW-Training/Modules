using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SSW.Training.Business.Tests.Unit
{
    [TestClass]
    public class StringValidationExtensionsTests
    {
        [TestMethod]
        public void IsValidEmailAddress_ForValidEmail_ReturnTrue()
        {
            //arrange
            var stringToTest = "adam@stephensen.me";

            //act
            var result = stringToTest.IsValidEmailAddress();

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidEmailAddress_ForInValidEmailContainingSpaces_ReturnFalse()
        {
            //arrange
            var stringToTest = "adam@stephensen .me";

            //act
            var result = stringToTest.IsValidEmailAddress();

            //assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void IsValidEmailAddress_ForInValidEmailContainingNoAt_ReturnFalse()
        {
            //arrange
            var stringToTest = "adamstephensen.me";

            //act
            var result = stringToTest.IsValidEmailAddress();

            //assert
            Assert.IsFalse(result);

        }
    }

}
