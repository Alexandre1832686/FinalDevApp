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
            

        }

        [TestMethod]
        public void ExceptionDocNotFound()
        {
            
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
