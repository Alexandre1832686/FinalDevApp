using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalDevApp;

namespace TestProject1
{
    [TestClass]
    public class AudioTest
    {
        [TestMethod]
        public void Constructeur()
        {
            Audio audio = new Audio("", -1000, "", "","");
        }
    }
}
