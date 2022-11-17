using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalDevApp;

namespace TestProject1
{
    [TestClass]
    public class DocumentTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Document doc = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul", "paul");
            Document doc2 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul", "paul");
            Document doc3 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul2", "paul");


            if (doc.CompareTo(doc2) != 0)
            {
                Assert.Fail();
            }

            if (doc.CompareTo(doc3) == 0)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            Document doc = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul", "paul");
            Membre membre = new Membre("alex");
            Membre membre2 = new Membre("alex1");
            Membre membre3 = new Membre("alex2");
            Membre membre4 = new Membre("alex3");


            if(!doc.AjouterMembreListeAttente(membre))
            {
                Assert.Fail();
            }
            if (!doc.AjouterMembreListeAttente(membre2))
            {
                Assert.Fail();
            }
            if (!doc.AjouterMembreListeAttente(membre3))
            {
                Assert.Fail();
            }
            if (doc.AjouterMembreListeAttente(membre4))
            {
                Assert.Fail();
            }


            if (!doc.EnleverMembreListeAttente(membre2))
            {
                Assert.Fail();
            }
            if (!doc.EnleverMembreListeAttente(membre3))
            {
                Assert.Fail();
            }

            if (!doc.AjouterMembreListeAttente(membre3))
            {
                Assert.Fail();
            }
            if (!doc.AjouterMembreListeAttente(membre4))
            {
                Assert.Fail();
            }


        }
    }
}
