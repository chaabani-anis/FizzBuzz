using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Should_return_Fizz_When_input_is_3()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            var output = fizzBuzz.GetOutput(3);
            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        public void Should_return_Fizz_When_input_is_5()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            var output = fizzBuzz.GetOutput(5);
            Assert.AreEqual("Buzz", output);
        }
    }
}
