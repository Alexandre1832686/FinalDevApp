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
            string path = "BD.txt";
            
            if (!File.Exists(path))
            {
                Assert.Fail();
            }

            List<Document> list = new List<Document>();
            list = Repertoire.ChargerDocuments(path);



            if (list[0].GetTitre() != "Geronimo")
            {
                Assert.Fail();
            }

        }
    }
}
