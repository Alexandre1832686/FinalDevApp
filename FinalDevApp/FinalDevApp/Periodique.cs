using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDevApp
{
    internal class Periodique : Document, IDescription, IImprime
    {
        int numero;
        int nbPages;
        int annee;

        public string GetDescription()
        {
            return "";
        }

        public int GetNbPages()
        {
            return nbPages;
        }
    }
}
