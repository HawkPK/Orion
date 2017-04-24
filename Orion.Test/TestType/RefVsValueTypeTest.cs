using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Test.TestType
{
    [TestClass]
    public class RefVsValueTypeTest { 

    [TestMethod]
        public void DoesItComputeCorrectly()
        {
            int c1 = 10;
            int c2 = c1;

            Assert.AreEqual(c1, c2);

            c1 = 100;

            Assert.AreNotEqual(c1, c2);
        }
    }
}
