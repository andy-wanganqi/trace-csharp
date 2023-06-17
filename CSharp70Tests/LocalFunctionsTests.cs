using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp70;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp70.Tests
{
    [TestClass()]
    public class LocalFunctionsTests
    {
        [TestMethod()]
        public void VariableCaptureTest()
        {
            var result = LocalFunctions.VariableCapture(100);
            Assert.AreEqual(100, result);
        }

        [TestMethod()]
        public void PlayTest()
        {
            var result = LocalFunctions.Play();
            Assert.AreEqual(101, result);
        }
    }
}