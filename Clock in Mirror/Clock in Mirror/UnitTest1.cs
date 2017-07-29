using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clock_in_Mirror
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_00_Should_Be_00()
        {
            var kata = new Kata();
            var input = "00";
            var actual = kata.WhatIsTheTime(input);
            var expected = "00";
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
            calculated -= int.Parse(cutString[0]);

            if (calculated == 60)
                calculated = 0;

            if (calculated.ToString().Length < 2)
                return "0" + calculated;

            return calculated.ToString();
        }
    }
}
