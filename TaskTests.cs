using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeodorovLabs
{
    class Task1Test
    {
        [TestCase(new object[] { 1, 2, "a", "b" }, new object[] { 1, 2 })]
        [TestCase(new object[] { 1, 2, "a", "b", 0, 15 }, new object[] { 1, 2, 0, 15 })]
        [TestCase(new object[] { 1, 2, "a", "b", "aasf", "1", "123", 231 }, new object[] { 1, 2, 231 })]

        public void GetIntegerFromListTest(object[] input_list, object[] output_list)
        {
            var res = Task1.GetIntegerFromList(input_list.ToList());
            Assert.AreEqual(res, output_list.ToList());
        }
    }
    class Task2Test
    {

        [TestCase("proSToRsP", 'T')]
        [TestCase("", ' ')]
        [TestCase("pprraavvddaa", ' ')]
        public void First_non_repeating_letter_Test(string input_str, char output_char)
        {
            var res = Task2.First_non_repeating_letter(input_str);
            Assert.AreEqual(res, output_char);
        }
    }
    class Task3Test
    {
        [TestCase(83, 2)]
        [TestCase(185, 5)]
        [TestCase(132232, 4)]
        [TestCase(493193345, 5)]

        public void DigitalRootTest(int input, int output)
        {
            var res = Task3.Digital_Root(input);
            Assert.AreEqual(res, output);
        }
    }
    class Task4Test
    {
        [TestCase(new int[] { 8, 8, 0, 5, 5, 5, 3, 5, 3, 5}, 9, 0)]
        [TestCase(new int[] { }, 6, 0)]
        [TestCase(new int[] { 6, 3, 5, 1, 0 }, 7, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 12, 2)]

        public void NumberOfPairsTest(int[] input, int target, int output)
        {
            var res = Task4.Number_of_pairs(input, target);
            Assert.AreEqual(res, output);
        }
    }
    class Task5Test
    {
        [TestCase("Alfred:Corwill;Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill", "(CORWILL, ALFRED)(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)")]
        [TestCase("", "")]

        public void MeetingTest(string input_str, string output_str)
        {
            var res = Task5.Meeting_Names(input_str);
            Assert.AreEqual(res, output_str);
        }
    }

}