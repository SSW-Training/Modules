using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SSW.Training.Tests.Unit
{

    public static class EmailValidator
    {
        public static bool ValidateEmail(this string email)
        {
            Regex r = new Regex(@"^[\w-]+(?:\.[\w-]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7}$"); // checks email
            Match m = r.Match(email);
            return m.Success;
        }
    }
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GoodEmailRegexTest()
        {
            string emailAddress = "joeblogs@blog.ville.com";
            Assert.IsTrue(emailAddress.ValidateEmail());
        }

        [TestMethod]
        public void BadEmailRegexTest()
        {
            string emailAddress = "joeshmo.com.au";
            Assert.IsFalse(emailAddress.ValidateEmail());
        }
    }
}


