using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsComponentNameSpace;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestMath
    {
        [TestMethod]
        public void TestAdd()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Add(10, 10); 
            Assert.AreEqual(20, result); // Checking the expected result
        }

        [TestMethod]
        public void TestSubstract()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Substract(10, 10); 
            Assert.AreEqual(0, result); // Checking the expected result
        }
    }
}
