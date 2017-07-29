﻿using System;
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
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Input_1201_Should_Be_1159()
        {
            var kata = new Kata();
            var input = "12:01";
            var actual = kata.WhatIsTheTime(input);
            var expected = "11:59";
            Assert.AreEqual(expected, actual);

        }

    }

    public class Kata
    {
        public string WhatIsTheTime(string input)
        {

            return input;
        }
    }
}
