using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture()]
    public class ClassWithFuncTests
    {
        ClassWithFunc func = new ClassWithFunc();
       
        [TestCase(new int[] {3, 5, 2, 7, 1}, new int[] {1, 2, 3, 5, 7})]
        [TestCase(new int[] { 1, 8, 3, 4 }, new int[] { 1, 3, 4, 8 })]
        [TestCase(new int[] {1, 2, 3, 4, 5  }, new int[] { 1, 2,  3, 4, 5 })]
        public void SortTest(int[] inputMas, int[] extMas)
        {
            ClassWithFunc.Sort(ref inputMas);
            Assert.AreEqual(extMas, inputMas);
        }

        [TestCase("шалаш", true)]
        [TestCase("шаллаш", true)]
        [TestCase("кошка", false)]
        public void PolindromTest(string input, bool ext)
        {

            Assert.AreEqual(ext, func.Polindrom(input));
        }

        [TestCase(5, 120)]
        [TestCase(-1, double.NaN)]
        [TestCase(0, 1)]
        public void FactTest(int inputNum, double ext)
        {
            Assert.AreEqual(ext, func.Fact(inputNum));
        }

        [TestCase(1, double.NaN)]
        [TestCase(2, 8)]
        [TestCase(4, 9)]
        public void FibTest(int index, double ext)
        {
            Assert.AreEqual(ext, func.Fib(index));
        }// 3, 5, 2, 7, 1

        [TestCase(1.5, 4.6, 6.46)]
        [TestCase(8.5, 1.6, 30.70)]
        [TestCase(0.05, 4.6, 0)]
        public void VeshTest(double a, double b, double output)
        {
            Assert.AreEqual(output, func.Vesh(a, b)); 
        }

        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(13, true)]
        [TestCase(4, false)]
        public void CheckTest(int value, bool ext)
        {
            Assert.AreEqual(ext, func.Check(value));
        }
    }
}