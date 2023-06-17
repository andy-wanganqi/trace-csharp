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
    public class LocalFunctionVSLambdaTests
    {
        [TestMethod()]
        public void LocalFunctionFactorialTest()
        {
            var result = LocalFunctionVSLambda.LocalFunctionFactorial(10);
            Assert.AreEqual(3628800, result);
        }

        [TestMethod()]
        public void LocalFunctionFactorial2Test()
        {
            var result = LocalFunctionVSLambda.LocalFunctionFactorial2(10);
            Assert.AreEqual(3628800, result);
        }

        [TestMethod()]
        public void LambdaFactorialTest()
        {
            var result = LocalFunctionVSLambda.LambdaFactorial(10);
            Assert.AreEqual(3628800, result);
        }
    }
}