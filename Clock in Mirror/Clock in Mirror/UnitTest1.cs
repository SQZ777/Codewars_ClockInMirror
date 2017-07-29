using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clock_in_Mirror
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_0500_Should_Be_0700()
        {
            GetClockResult("07:00", "05:00");
        }

        [TestMethod]
        public void Input_0600_Should_Be_0600()
        {
            GetClockResult("06:00", "06:00");
        }

        [TestMethod]
        public void Input_0100_Should_Be_1100()
        {
            GetClockResult("11:00", "01:00");
        }

        [TestMethod]
        public void Input_0101_Should_Be_1059()
        {
            GetClockResult("10:59", "01:01");
        }

        [TestMethod]
        public void Input_1201_Should_Be_1159()
        {
            GetClockResult("11:59", "12:01");
        }

        [TestMethod]
        public void Input_0301_Should_Be_0859()
        {
            GetClockResult("08:59", "03:01");
        }
        [TestMethod]
        public void Input_0630_Should_Be_0530()
        {
            GetClockResult("05:30", "06:30");
        }
        [TestMethod]
        public void Input_1200_Should_Be_1200()
        {
            GetClockResult("12:00", "12:00");
        }

        [TestMethod]
        public void Input_1158_Should_Be_1202()
        {
            GetClockResult("11:58", "12:02");
        }

        private static void GetClockResult(string expected, string input)
        {
            var kata = new Kata(); //arrange 
            var actual = kata.WhatIsTheTime(input);//act
            Assert.AreEqual(expected, actual); //assert
        }
    }

    public class Kata
    {
        public string WhatIsTheTime(string timeInMirror)
        {

            var hh = 12 - int.Parse(timeInMirror.Substring(0, 2));
            var mm = (60 - int.Parse(timeInMirror.Substring(3))) % 60;
            if (mm != 0) --hh;
            if (hh <= 0) hh += 12;
            return $"{hh:00}:{mm:00}";


            var cutString = timeInMirror.Split(':');
            var min = GetMirrorMinute(cutString[1]);
            var minOverZero = int.Parse(min) > 0;
            var hour = GetMirrorHour(cutString[0], minOverZero);

            return string.Concat(hour,":",min);
        }

        private static string GetMirrorHour(string cutString, bool minOverZero)
        {
            var twelve = 12;
            if (minOverZero)
                twelve -= 1;
            var result = twelve - int.Parse(cutString);
            if (result <= 0)
                result += 12;
            return result < 10 ? "0" + result : result.ToString();
        }

        private static string GetMirrorMinute(string cutString)
        {
            var calculated = 60 - int.Parse(cutString);
            if (calculated == 60)
                calculated = 0;
            if (calculated.ToString().Length < 2)
                return "0" + calculated;
            return calculated.ToString();
        }
    }
}
