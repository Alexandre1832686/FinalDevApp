using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalDevApp;
using System.Collections.Generic;
using System.IO;
using System;

namespace TestProject1
{
    [TestClass]
    public class RepertoireTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string fileName = "BD.txt";
            string path = "../../../../" + fileName;
            

            if (!File.Exists(path))
            {
                Assert.Fail();
            }


            List<Document> list = new List<Document>();
            list = Repertoire.ChargerDocuments(fileName);


            if (list[0].GetTitre() != "Geronimo")
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void ExceptionDocNotFound()
        {
            Document doc = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul", "paul");
            Document doc2 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul2", "paul");
            Document doc3 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul3", "paul");
            List<Document> list = new List<Document>();
            list.Add(doc);
            list.Add(doc2);
            list.Add(doc3);

            Repertoire r = new Repertoire(list,"monRep");

            if (r.TrouverDocument("Le livre de paul", "paul") != doc)
            {
                Assert.Fail();
            }

            try
            {
                r.TrouverDocument("Le livre de pauline", "pauline");
            }
            catch(DocumentNotFoundException e)
            {
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void ExceptionLectureFichier()
        {
            List<Document> list = new List<Document>();
            try
            {
                list = Repertoire.ChargerDocuments("BD2.txt");
            }
            catch(EnregistrementDocumentErrorException e)
            {
                return;
            }


            Assert.Fail();
        }


    }
}
