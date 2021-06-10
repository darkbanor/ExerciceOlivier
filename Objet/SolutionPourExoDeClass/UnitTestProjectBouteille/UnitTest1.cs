using ClassLibraryBouteille;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectBouteille
{
    [TestClass]
    public class UnitTest_Bouteille
    {
        [TestMethod]
        public void Ouvrir_QuandFerme_ReturnTrue()
        {
            Bouteille uneBouteilleDeperrier;
            uneBouteilleDeperrier = new Bouteille(1.5, 80, false);

            
            bool test = uneBouteilleDeperrier.Ouvrir();

            Assert.AreEqual(test, true);
            Assert.AreEqual(uneBouteilleDeperrier.Ouvert, true);
        }
    }
}
