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
        List<Document> listeEmprunts;
        int noMembre;
        static int nbMembresTotal;

        public string GetNom()
        {
            return nom;
        }

        public Membre(string nom_p)
        {
            this.nom = nom_p;
            this.listeEmprunts = new List<Document>();
            this.noMembre = ++nbMembresTotal;
        }

        public void SetNom(string newNom)
        {
            nom = newNom;
        }

        public List<Document> GetListeEmprunt()
        {
            return listeEmprunts;
        }

        public int GetNombreEmprunt()
        {
            return listeEmprunts.Count;
        }
        
        public int GetNoMembre()
        {
           return noMembre;
        }

        public bool AjouterDocument(Document nouveau)
        {
            if(GetNombreEmprunt()<4)
            {
                listeEmprunts.Add(nouveau);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RetirerDocument(Document retrait)
        {
            return listeEmprunts.Remove(retrait);
        }


    }
}
