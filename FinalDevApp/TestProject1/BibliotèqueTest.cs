using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalDevApp;

namespace TestProject1
{
    [TestClass]
    public class BibliotèqueTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Biblioteque normal = new Biblioteque("normal");
            Biblioteque perso = new Biblioteque("perso", 15);
            Biblioteque petite = Biblioteque.CréerPetiteBiblioteque("petite");
            Biblioteque moyenne = Biblioteque.CréerMoyenneBiblioteque("moyenne");
            Biblioteque grande = Biblioteque.CréerGrandeBiblioteque("grande");

            if(normal.GetMembres().Length != 10)
            {
                Assert.Fail();
            }

            if (perso.GetMembres().Length != 15)
            {
                Assert.Fail();
            }

            if (petite.GetMembres().Length != 10)
            {
                Assert.Fail();
            }

            if (moyenne.GetMembres().Length != 100)
            {
                Assert.Fail();
            }

            if (grande.GetMembres().Length != 500)
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void TestMethod2()
        {
            Membre monMembre = new Membre("alex");
            Membre monMembre2 = new Membre("alex2");
            Document doc = new Livre("paul's editor inc", new System.DateTime(), 4,"bien","45165166","Le livre de paul", "paul");
            Biblioteque bibli = new Biblioteque("labibli");
            if(!bibli.AjouterMembre(monMembre))
            {
                Assert.Fail();
            }
            if (!bibli.AjouterMembre(monMembre2))
            {
                Assert.Fail();
            }

            if (!bibli.NotifierEmprunt(monMembre.GetNom(), doc))
            {
                Assert.Fail();
            }

            //suposer pas marcher et retourner false
            if (bibli.NotifierEmprunt(monMembre2.GetNom(), doc))
            {
                Assert.Fail();
            }

            if (doc.GetListeAttente()[0] != monMembre2)
            {
                Assert.Fail();
            }


            if(!bibli.NotifierRetour(doc))
            {
                Assert.Fail();
            }

            if (doc.GetEmprunteur() != monMembre2)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            Biblioteque bib = new Biblioteque("bibli");

            for(int i =0;i<10;i++)
            {
                Membre monMembre = new Membre("alex");
                if(!bib.AjouterMembre(monMembre))
                {
                    Assert.Fail();
                }
            }

            Membre monMembre2 = new Membre("alex2");

            if (bib.AjouterMembre(monMembre2))
            {
                Assert.Fail();
            }
        }
    }
}
