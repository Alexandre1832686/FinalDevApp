using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDevApp
{
    internal class Repertoire
    {
        List<Document> listeDocuments;
        string nom;

        public List<Document> GetListeDocuments()
        {
            return listeDocuments;
        }

        public string GetNom()
        {
           return nom;  
        }

        public List<Document> GetListAttente()
        {
            List<Document> listeRetour = new List<Document>();

            foreach (Document d in listeDocuments)
            {
                if (d.GetListeAttente()[0] != null)
                {
                   listeRetour.Add(d);
                }
            }

            return listeRetour;

        }

        public List<Document> GetListeEmprunts()
        {
            List<Document> listeRetour = new List<Document>();

            foreach (Document d in listeDocuments)
            {
                if (d.GetEmprunteur() != null)
                {
                    listeRetour.Add(d);
                }
            }

            return listeRetour;
        }

        public Repertoire(List<Document> listeDocuments, string nomRepertoire)
        {
            this.listeDocuments = listeDocuments;
            this.nom = nomRepertoire;
        }

        public List<Document> ChargerDocuments(string nomFichier)
        {

        }

        public Document TrouverDocument(string titre, string auteur)
        {
            
            foreach(Document d in listeDocuments)
            {
                if(d.GetAuteur() == auteur && d.GetTitre() == titre)
                {
                    return d;
                }
            }
            
            return null;
        }

        public bool AjouterDocument(Document nouveauDoc)
        {
            listeDocuments.Add(nouveauDoc);
            return true;
        }

        public bool suprimerDocument(Document docASuprimer)
        {
            listeDocuments.Remove(docASuprimer);
            return true;
        }

        public bool VerifierDisponibilite(Document docAVerifier)
        {
            return docAVerifier.estDisponible();
        }
    }
}
