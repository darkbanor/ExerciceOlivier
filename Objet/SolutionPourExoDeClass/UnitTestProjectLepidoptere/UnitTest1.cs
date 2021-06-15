using ClassLibraryLepidoptere;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectLepidoptere
{
    [TestClass]
    public class UnitTestLepidoptere
    {
        [TestMethod]
        public void StadeCourantEstDifferentDeDonnerProchainStadeEqualATrue()
        {
            //arrange
            Lepidoptere test;
            test = new Lepidoptere("TestUnitaire");

            //act
            test.SeTransformerObjet();
            

            //assert
            //Assert.IsInstanceOfType( (test.GetType(), typeof(Lepidoptere));
           
        }
    }
}
