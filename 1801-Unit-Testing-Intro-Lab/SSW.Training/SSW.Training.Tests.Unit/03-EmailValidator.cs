using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SSW.Training.Tests.Unit
{
    public static class StringValidation
    {
        public static bool IsValidEmailAdress(this string email)
        {
            Regex regex = new Regex(@"^[\w-]+(?:\.[\w-]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7}$");
            Match match = regex.Match(email);
            return match.Success;
        }
    }


[TestClass]
public class StringValidationTests
{
    [TestMethod]
    public void IsValidEmailAddress_ForValidEmail_ReturnTrue()
    {
        //arrange
        var stringToTest = "adam@stephensen.me";

        //act
        var result = stringToTest.IsValidEmailAdress();

        //assert
        Assert.IsTrue(result);
    }
    

[TestMethod]
    public void IsValidEmailAddress_ForInValidEmailContainingSpaces_ReturnFalse()
    {
        //arrange
        var stringToTest = "adam@stephensen .me";

        //act
        var result = stringToTest.IsValidEmailAdress();

        //assert
        Assert.IsFalse(result);

    }
    [TestMethod]
    public void IsValidEmailAddress_ForInValidEmailContainingNoAt_ReturnFalse()
    {
        //arrange
        var stringToTest = "adamstephensen.me";

        //act
        var result = stringToTest.IsValidEmailAdress();

        //assert
        Assert.IsFalse(result);

    }
}

    [TestFixture]
    public class StringValidationTests_Nunit
    {
        [TestCase("adam@domain.com", Description = "Valid simple email")]
        [TestCase("adam-stephensen@domain-name.com", Description = "Valid email can contain hypens")]
        [TestCase("adam.stephensen.more@domain.com.au", Description = "Valid email can contain multiple periods")]
        public void IsValidEmailAddress_ForValidEmails_ReturnsTrue(string email)
        {
            bool result = email.IsValidEmailAdress();

            Assert.IsTrue(result);
        }

        [TestCase("adam@domain&more.com", Description = "Invalid email containing ampersand")]
        [TestCase("@domain&other.com", Description = "Invalid email with no text before @")]
        [TestCase("adam@", Description = "Invalid email with no text after @")]
        [TestCase("adam@domain", Description = "Invalid email with no period after @")]
        [TestCase("adam-domain.com", Description = "Email does not contain @")]
        [TestCase("adam.@domain.com", Description = "Email cannot contain period directly before @")]
        [TestCase("adam@.domain.com", Description = "Email cannot contain period directly after @")]
        [TestCase(".adam@domain.com", Description = "Email cannot start with period")]
        [TestCase("adam@domain.com.", Description = "Email cannot end with period")]
        public void IsValidEmailAddress_ForInvalidEmail_ReturnsFalse(string email)
        {
            var result = email.IsValidEmailAdress();

            Assert.IsFalse(result);
        }
    }
}
