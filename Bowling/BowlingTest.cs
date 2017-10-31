using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bowling
{
    [TestClass]
    public class BowlingTest
    {
        [TestMethod]
        public void Input_zero_Shouldbe_zero()
        {
            int[] score = {};
            AssertShouldBe(score, 0);
        }

        [TestMethod]
        public void Input_oneone_Shouldbe_two()
        {
            int[] score = {1,1};
            AssertShouldBe(score,2);
        }

        [TestMethod]
        public void Input_onetwoeight_Shouldbe_tweleve()
        {
            int[] score = { 1, 0, 2, 8};
            AssertShouldBe(score, 12);
        }

        private static void AssertShouldBe(int[] ary, int expected)
        {
            var kata = new Kata();
            var actual = kata.SumScore(ary);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int SumScore(int[] score)
        {
            if (score == null || score.Length <= 0)
            {
                return 0;
            }

            int sum = 0;
            int firstset = 0;
            int secondset = 0;
            int nowset = 0;

            for (int i = 0; i < score.Length; i++)
            {
                //sum += score[i];
                int set = 0;
                if (i % 2 == 1)
                {
                    set = score[i] + score[i - 1];
                    if (score[i] == 10 || score[i - 1]==10)
                    {
                        //Strike
                    }

                    if (set == 10)
                    {
                        //Spare
                    }
                    sum += set;
                }
            }
            return sum;
        }

        public int Strike(int first, int second, int current)
        {
            int sum = 0;
            return sum;
        }

        public int Spare(int first, int current)
        {
            int sum = 0;
            return sum;
        }
    }

}
