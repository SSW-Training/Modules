using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace SSW.Training.WebUI.Tests.Unit
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        string Mode { get; set; }
    }
    public class ClassUnderTest
    {
        private readonly ICalculator _calculator;

        public ClassUnderTest(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int AddAndDouble(int a, int b)
        {
            return _calculator.Add(a, b) * 2;
        }

    }
    [TestClass]
    public class CalculatorTests
    {

        ICalculator _calculator;

        [TestInitialize]
        public void InitialiseTest()
        {
            //We can tell our substitute to return a value for a call:
            _calculator = Substitute.For<ICalculator>();
        }

        [TestMethod]
        public void Add_SpecificValues_ReturnsCorrectResult()
        {
            //We can tell our substitute to return a value for a call:
            _calculator.Add(1, 2).Returns(3);

            var result = _calculator.Add(1, 2);

            Assert.AreEqual(result, 3);
        }


        [TestMethod]
        public void Add_ArgumentValues_ReturnsCorrectResult()
        {
            //We can tell our substitute to return a value for a call, regardless of what the parameters are.
            //While not helpful for our calculator, this is very useful in more complex mocking situations
            //_contactRepository.GetByID(Arg.Any<int>()).Returns(new Contact{ID=1,FirstName="Adam"});
            _calculator.Add(Arg.Any<int>(), Arg.Any<int>()).Returns(3);
            Assert.IsTrue(_calculator.Add(1, 2) == 3);
        }



        [TestMethod]
        public void AddAndDouble_Scenariotes_CallsTheAddMethodCorrectly()
        {
            //arrange
            var classUnderTest = new ClassUnderTest(_calculator);

            //act
            classUnderTest.AddAndDouble(1, 2);

            //assert
            //.Recevied() = .AssertThatTheFollowMethodWasCalled()
            _calculator.Received().Add(1, 2);

            //.DidNotReceive() = .AssertThatTheFollowMethodWasNotCalled()
            _calculator.DidNotReceive().Add(1, 3);

            //_calculator.Received().Add(1, 3); //Fails: Received 1 non-matching call (non-matching arguments indicated with '*' characters): Add(1, *2*)

            //_calculator.DidNotReceive().Add(1, 2); //Fails: NSubstitute.Exceptions.ReceivedCallsException: Expected to receive no calls matching: Add(1, 2). Actually received 1 matching call: Add(1, 2)

            //_calculator.Received().Subtract(1, 3); //Fails: NSubstitute.Exceptions.ReceivedCallsException: Expected to receive a call matching:Subtract(1, 3). Actually received no matching calls.
        }

        [TestMethod]
        public void WeCanValidateProperties()
        {
            //We can also work with properties using the Returns syntax we use for methods, or just stick with plain old property setters (for read/write properties):

            _calculator.Mode.Returns("DEC");
            Assert.AreEqual(_calculator.Mode, "DEC");

            _calculator.Mode = "HEX";
            Assert.AreEqual(_calculator.Mode, "HEX");
        }

        [TestMethod]
        public void Test_UseArgumentMatching_ToSetReturnValues_AndAssertACallWasRecived()
        {
            _calculator.Add(10, -5);
            _calculator.Received().Add(10, Arg.Any<int>());
            _calculator.Received().Add(10, Arg.Is<int>(x => x < 0));
            //_calculator.Received().Add(10, Arg.Is<int>(x => x > 0)); //Fails
        }

        [TestMethod]
        public void Test_UseArgumentMatchingAndPassingAFunctionToReturns()
        {
            _calculator
               .Add(Arg.Any<int>(), Arg.Any<int>())
               .Returns(paramArray => (int)paramArray[0] + (int)paramArray[1]);
            Assert.AreEqual(_calculator.Add(5, 10), 15);
        }

    }


    //todo: 
    //Returns() can also be called with multiple arguments to set up a sequence of return values.
    //    _calculator.Mode.Returns("HEX", "DEC", "BIN");
    //    Assert.That(_calculator.Mode, Is.EqualTo("HEX"));
    //    Assert.That(_calculator.Mode, Is.EqualTo("DEC"));
    //    Assert.That(_calculator.Mode, Is.EqualTo("BIN"));

    //todo: 
    //Finally, we can raise events on our substitutes (unfortunately C# dramatically restricts the extent to which this syntax can be cleaned up):
    //    bool eventWasRaised = false;
    //    _calculator.PoweringUp += () => eventWasRaised = true;
    //    _calculator.PoweringUp += Raise.Event<Action>();
    //    Assert.That(eventWasRaised);

}
