using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TRechner;

namespace Rechner.Test
{
    [TestClass]
    public class TestRechner
    {
        /* #################
               Addieren
           ################# */

        [TestMethod]
        public void add()
        {
            Assert.AreEqual(TRechner.Rechner.add(1,2), 3);
        }

        [TestMethod]
        public void Addnegative()
        {
            Assert.AreEqual(TRechner.Rechner.add(-1, 2), 1);
        }

        /* #################
              Dividieren
           ################# */

        [TestMethod]
        public void Divide()
        {
            Assert.AreEqual(TRechner.Rechner.divide(2, 1), 2);
        }


        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Dividebyzero()
        {
            TRechner.Rechner.divide(1, 0);
        }

    }
}
