using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDevApp
{
    public class Membre
    {
        string nom;
        Document[] listeEmprunts;
        int noMembre;
        static int nbMembresTotal;

        public string GetNom()
        {
            return nom;
        }
    }
}
