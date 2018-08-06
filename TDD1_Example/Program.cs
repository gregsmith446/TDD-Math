using System;
using MathComponentNameSpace;
using NUnit.Framework;

namespace MathTestProject
{
    class Program
    {
		private void Main(string[] args)
        {
            Console.WriteLine("Hi");
        }

        [Test]
        public void TestCaseAdd()
        {
            MathComponent obj = new MathComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
            // this is ONLY the test case
            // no actual program code
        }

        [Test]
        public void TestCaseSubtract()
        {
            MathComponent obj = new MathComponent();
            int result = obj.Subtract(10, 9);
            Assert.AreEqual(1, result);
        }
    }
}