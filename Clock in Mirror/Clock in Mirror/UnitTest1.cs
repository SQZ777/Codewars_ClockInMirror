using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clock_in_Mirror
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_1200_Should_Be_1200()
        {
            var kata = new Kata();
            var input = "12:00";
            var actual = kata.WhatIsTheTime(input);
            var expected = "12:00";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_01_Should_Be_59()
        {
            var kata = new Kata();
            var input = "01";
            var actual = kata.WhatIsTheTime(input);
            var expected = "59";
            Assert.AreEqual(expected, actual);

        }

    }

    public class Kata
    {
        public string WhatIsTheTime(string input)
        {
            //cut hour and minute
            var cutString = input.Split(':');

            //calculate minute
            var calculated = 60;
            if (cutString.Length < 2)
            {
                calculated -= int.Parse(cutString[0]);
            }

            return calculated.ToString();
        }
    }
}
