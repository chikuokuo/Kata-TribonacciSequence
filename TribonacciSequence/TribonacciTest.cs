using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TribonacciSequence
{
    [TestClass]
    public class TribonacciTest
    {
        [TestMethod]
        public void Input_111_0_shouldReturn_1_1_1()
        {
            var result = Variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 0);

            CollectionAssert.AreEqual(new double[] {0}, result);
        }

        [TestMethod]
        public void Input_111_2_shouldReturn_1_1()
        {
            var result = Variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 2);

            CollectionAssert.AreEqual(new double[] {1, 1}, result);
        }

        [TestMethod]
        public void Input_111_3_shouldReturn_1_1_1()
        {
            var result = Variabonacci.Tribonacci(new double[] {1, 1, 1}, 3);

            CollectionAssert.AreEqual(new double [] {1, 1, 1}, result);
        }

        [TestMethod]
        public void Input_111_4_shouldReturn_1_1_1_3()
        {
            var result = Variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 4);

            CollectionAssert.AreEqual(new double[] { 1, 1, 1, 3 }, result);
        }

        [TestMethod]
        public void Input_111_5_shouldReturn_1_1_1_3_5()
        {
            var result = Variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 5);

            CollectionAssert.AreEqual(new double[] { 1, 1, 1, 3, 5 }, result);
        }

        [TestMethod]
        public void Input_111_10_shouldReturn_1_1_1_3_5_9_17_31_57_105()
        {
            var result = Variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 10);

            CollectionAssert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, result);
        }

        [TestMethod]
        public void Input_001_10_shouldReturn_0_0_1_1_2_4_7_13_24_44()
        {
            var result = Variabonacci.Tribonacci(new double[] { 0, 0, 1 }, 10);

            CollectionAssert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, result);
        }
    }

    public static class Variabonacci
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
            {
                return new double[]{0};
            }
            var tempSignature = signature.ToList();
            for (int i = 0; i < n - 3; i++)
            {
                tempSignature.Add(tempSignature[i] + tempSignature[i+1] + tempSignature[i+2]);
            }
            
            return tempSignature.Take(n).ToArray();
        }
    }
}
