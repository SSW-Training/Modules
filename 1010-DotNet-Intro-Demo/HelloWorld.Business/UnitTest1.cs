using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//Everyone's first method should contain Assert.AreEqual(greeting,"Hello World") not Console.WriteLine("Hello World"). #TeachUnitTestingFromDayOne
namespace HelloWorld.Business
{
    //EXAMPLE: Introduce method, variable, strings
    public class MessageGenerator
    {
        public string GetGreeting()
        {
            string greeting;

            greeting = "Hello world";

            return greeting;
        }
    }

    //test our class to see if it works
    public class MessageGeneratorTester
    {
        public void GetGreeting_Always_ReturnsHelloWorld()
        {
            //create an instance of a class
            var generator = new MessageGenerator();

            //calling the method
            var output = generator.GetGreeting();

            //output the string
            Trace.WriteLine(output);
            //if instead of outputing to the screen and us checking the output
            //   we would like to automate checking the result 
        }
    }

    [TestClass]
    public class MessageGeneratorTests
    {
        [TestMethod]
        public void GetGreeting_Always_ReturnsHelloWorld()
        {
            //ARRANGE
            //create an instance of a class
            var generator = new MessageGenerator();

            //ACT
            //calling the method
            var output = generator.GetGreeting();

            //ASSERT
            //if (output != "Hello World") throw new InvalidOperationException();
            Assert.AreEqual("Hello World", output);

        }
    }

}















namespace HelloWorld.Business.IntroducingMethods
{

    public class MessageGenerator
    {
        public static string GetGreeting()
        {
            return "Hello world";
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string greeting = MessageGenerator.GetGreeting();

            Assert.AreEqual(greeting, "Hello world");
        }
    }
}

namespace MyFirstApp.IntroducingMethods.Refactored
{

    public class MyFirstClass
    {
        public static string GetGreeting(string target)
        {
            return "Hello " + target;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string greeting = MyFirstClass.GetGreeting("world");

            Assert.AreEqual(greeting, "Hello world");
        }
    }
}

namespace MyFirstApp.Operators
{
    /*
    Category 	        Operator(s)	 
    Primary	            x.y  f(x)  a[x]  x++  x--  new  typeof  default  checked  unchecked delegate	 
    Unary	            +  -  !  ~  ++x  --x  (T)x	 
    Multiplicative	    *  /  %	 
    Additive	        +  -	 
    Shift	            <<  >>	 
    Relational	        <  >  <=  >=  is as	 
    Equality	        ==  !=	 
    Logical AND	        &	 
    Logical XOR	        ^	 
    Logical OR	        |	 
    Conditional AND	    &&	 
    Conditional OR	    ||	 
    Null Coalescing	    ??	 
    Ternary	            ?:	 
    Assignment	        =  *=  /=  %=  +=  -=  <<=  >>=  &=  ^=  |=  =>
    */

    [TestClass]
    public class OperatorTests
    {
        [TestMethod]
        public void Addition_Always_ReturnsTheCorrectSum()
        {
            var result = 123 + 456;

            Assert.AreEqual(579, result);
        }
        [TestMethod]
        public void Modulus_Always_ReturnsTheRemainder()
        {
            var result = 3 % 2;

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Modulus_EvenDividedByTwo_ReturnsZeroRemainder()
        {
            var result = 4 % 2;

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void EqualityOperator_WhenAppliedToEqualStrings_RetursTrue()
        {
            var result = "Adam" == "Adam";

            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void EqualityOperator_WhenAppliedToEqualNumbers_RetursTrue()
        {
            var result = 512 == 512;

            Assert.AreEqual(result, true);
        }
        public void EqualityOperator_WhenAppliedToDifferentNumbers_RetursFalse()
        {
            var result = 512 == 513;

            Assert.AreEqual(result, false);
        }
        public void InequalityOperator_WhenAppliedToDifferentNumbers_RetursTrue()
        {
            var result = 512 != 513;

            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void LogicalAnd_WhenBothStatementsAreTrue_ReturnsTrue()
        {
            var result = 124 > 12 && "adam".Length == 4;

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LogicalAnd_WhenBothStatementsAreNotTrue_ReturnsFalse()
        {
            var result = 124 > 12 && "adam".Length == 0;

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void LogicalOr_WhenBothStatementsAreTrue_ReturnsTrue()
        {
            var result = 124 > 12 || "adam".Length == 4;

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LogicalOr_WhenOneStatementIsTrue_ReturnsTrue()
        {
            var result = 124 > 12 || "adam".Length == 0;

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LogicalOr_WhenNeitherStatementIsTrue_ReturnsFalse()
        {
            var result = 124 < 12 || "adam".Length == 0;

            Assert.AreEqual(false, result);
        }

    }
}





namespace HelloWorld.Business.IntroducingDI
{

    //step 1: create the class

    //Rule: don't use new XX(), except in the contructor

    public class whateverform
    {

        public whateverform()
            : this(new MessageGenerator())
        {

        }

        public whateverform(MessageGenerator generator)
        {
            xx = generator;
        }

        MessageGenerator xx;

        public void bind_click()
        {

            xx = new MessageGenerator();
            var output = xx.GetGreeting();
        }


        public void bind_click2()
        {

            xx = new MessageGenerator();
            var output = xx.GetGreeting();
        }
    }


    public class MessageGenerator
    {
        public string GetGreeting()
        {
            string greeting = "Hello world";

            return greeting;
        }
    }

    //step 2: create the console application
    //aa

    //step 3: introduce tests... 
    public class MessageGeneratorTests
    {
        public bool GetGreeting_Always_ReturnsHelloWorld()
        {
            //create an instance of a class
            var generator = new MessageGenerator();

            //calling the method
            var output = generator.GetGreeting();

            //assigning a comparison
            var success = output == "HelloWorld";

            return success;

            if (!success)
                throw new Exception("Values do not match");

        }
    }
}



