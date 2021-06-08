using ClassLibraryBouteille;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectBouteille
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bouteille uneBouteilleDeperrier;
            uneBouteilleDeperrier = new Bouteille(1.5, 80, false);

            uneBouteilleDeperrier.Ouvrir();
            bool test = uneBouteilleDeperrier.Ouvrir();

            Assert.AreEqual(test, true);
        }
    }
}
