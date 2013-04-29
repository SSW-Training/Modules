using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SSW.Training.Tests.Unit
{
    public static class CreditCardValidator
    {
        public static bool IsValidCreditCardNumber(this string valueToValidate)
        {
            if (string.IsNullOrWhiteSpace(valueToValidate)) return false;

            int indicator = 1;		//indicator for every other number
            int firstNumToAdd = 0;  //used to store sum of first set of numbers
            int secondNumToAdd = 0; //be used to store second set of numbers
            string num1;	        //used if every other number added is greater than 10, store the left-most integer here
            string num2;	        //if every other number added is greater than 10, store the right-most integer here

            //-- Convert our creditNo string to a char array
            char[] ccArr = valueToValidate.ToCharArray();

            for (int i = ccArr.Length - 1; i >= 0; i--)
            {
                char ccNoAdd = ccArr[i];
                int ccAdd = 0;

                bool result = Int32.TryParse(ccNoAdd.ToString(), out ccAdd);
                if (!result)
                    return false;

                if (indicator == 1)
                {
                    //If we are on the odd number of numbers, add that number to our total
                    firstNumToAdd += ccAdd;
                    //set our indicator to 0 so that our code will know to skip to the next piece
                    indicator = 0;
                }
                else
                {
                    //if the current integer doubled is greater than 10 split the sum in to two integers and add them together
                    //we then add it to our total here
                    if ((ccAdd + ccAdd) >= 10)
                    {
                        int temporary = (ccAdd + ccAdd);
                        num1 = temporary.ToString().Substring(0, 1);
                        num2 = temporary.ToString().Substring(1, 1);
                        secondNumToAdd += (Convert.ToInt32(num1) + Convert.ToInt32(num2));
                    }
                    else
                    {
                        //otherwise, just add them together and add them to our total
                        secondNumToAdd += ccAdd + ccAdd;
                    }
                    //set our indicator to 1 so for the next integer we will perform a different set of code
                    indicator = 1;
                }
            }
            //If the sum of our 2 numbers is divisible by 10,
            //then the card is valid. Otherwise, it is not
            bool isValid = (firstNumToAdd + secondNumToAdd) % 10 == 0;

            return isValid;
        }

    }


    [TestFixture]
    public class CreditCardValidatorTests
    {
        //card numbers from paypal http://www.paypalobjects.com/en_US/vhelp/paypalmanager_help/credit_card_numbers.htm
        [TestCase("378282246310005", Description = "Amex")]
        [TestCase("371449635398431", Description = "Amex")]
        [TestCase("378734493671000", Description = "Amex  Express Corporate")]
        [TestCase("5610591081018250", Description = "Australian BankCard")]
        [TestCase("30569309025904", Description = "Diners Club")]
        [TestCase("38520000023237", Description = "Diners Club")]
        [TestCase("6011111111111117", Description = "Discover")]
        [TestCase("6011000990139424", Description = "Discover")]
        [TestCase("5555555555554444", Description = "MasterCard")]
        [TestCase("5105105105105100", Description = "MasterCard")]
        [TestCase("4111111111111111", Description = "Visa")]
        [TestCase("4012888888881881", Description = "Visa")]
        [TestCase("4222222222222", Description = "Visa - A short number, but still valid")]
        public void IsValidCreditCardNumber_ForValidEmails_ReturnsTrue(string cardNumber)
        {
            bool result = cardNumber.IsValidCreditCardNumber();

            Assert.IsTrue(result);
        }

        [TestCase("401288888888188", Description = "Example Visa - Less last digit")]
        [TestCase("4012888888881880", Description = "Example Visa - Subtract one")]
        [TestCase("", Description = "Empty")]
        public void IsValidEmailAddress_ForInvalidEmail_ReturnsFalse(string cardNumber)
        {
            var result = cardNumber.IsValidCreditCardNumber();

            Assert.IsFalse(result);
        }
    }
}