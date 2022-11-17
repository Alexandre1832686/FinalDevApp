using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalDevApp;

namespace TestProject1
{
    [TestClass]
    public class MembreTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Membre membre1 = new Membre("a");
            Membre membre2 = new Membre("b");
            Membre membre3 = new Membre("c");
            Membre membre4 = new Membre("d");

            if(membre4.GetNoMembre() != membre1.GetNoMembre() + 3)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            Membre membre1 = new Membre("a");
            Document doc = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul", "paul");
            Document doc2 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul4", "paul");
            Document doc3 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul3", "paul");
            Document doc4 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul2", "paul");

            membre1.AjouterDocument(doc);
            membre1.AjouterDocument(doc2);
            membre1.AjouterDocument(doc3);

            if(membre1.AjouterDocument(doc4))
            {
                Assert.Fail();
            }

            if (!membre1.RetirerDocument(doc3))
            {
                Assert.Fail();
            }

            if (!membre1.AjouterDocument(doc4))
            {
                Assert.Fail();
            }
        }
    }
}
