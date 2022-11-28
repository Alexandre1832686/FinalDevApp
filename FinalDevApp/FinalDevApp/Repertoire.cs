using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDevApp
{
    public class Repertoire
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
            List<Document> list = new List<Document>();

            foreach (Document d in listeDocuments)
            {
                if(d.GetListeAttente() != null)
                {
                    list.Add(d);
                }
            }

            return list;
        }

        public List<Document> GetListeEmprunts()
        {
            List<Document> list = new List<Document>();

            foreach (Document d in listeDocuments)
            {
                if (d.GetEmprunteur() != null)
                {
                    list.Add(d);
                }
            }

            return list;
        }

        public Repertoire(List<Document> listeDocuments, string nomRepertoire)
        {
            this.listeDocuments = listeDocuments;
            this.nom = nomRepertoire;
        }

        public static List<Document> ChargerDocuments(string nomFichier)
        {
            FileStream f = new FileStream("../../../../" + nomFichier, FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            List<Document> documents = new List<Document>();
            
            string line;

            while ((line = s.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                switch(data[0])
                {
                    case "Livre":
                        Document monLivre = new Livre(data[1], new DateTime(int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4])), int.Parse(data[5]), data[6], data[7], data[8], data[9]);
                        documents.Add(monLivre);
                        break;
                    case "Audio":
                        Document monAudio = new Audio(data[1], Int32.Parse(data[2]), data[3], data[4], data[5]);
                        documents.Add(monAudio);
                        break;
                    case "Periodique":
                        Document monPeriodique = new Periodique(Int32.Parse(data[1]), Int32.Parse(data[2]), Int32.Parse(data[3]), data[4], data[5], data[6]);
                        documents.Add(monPeriodique);
                        break;
                    default:
                        throw new EnregistrementDocumentErrorException();
                        
                }
            }
            

            s.Close();
            f.Close();
            return documents;
        }

        public Document TrouverDocument(string titre, string auteur)
        {
            foreach (Document d in listeDocuments)
            {
                if (d.GetTitre() == titre && d.GetAuteur() == auteur)
                {
                    return d;
                }
            }

            throw new DocumentNotFoundException(titre, this.nom);
        }

        public bool AjouterDocument(Document nouveauDoc)
        {
            if(nouveauDoc != null && !listeDocuments.Contains(nouveauDoc))
            {
                listeDocuments.Add(nouveauDoc);
                return true;
            }
            
            return false;
        }

        public bool suprimerDocument(Document docASuprimer)
        {
            if (docASuprimer != null && listeDocuments.Contains(docASuprimer))
            {
                listeDocuments.Remove(docASuprimer);
                return true;
            }
            
            return false;
        }

        public bool VerifierDisponibilite(Document docAVerifier)
        {
            if (docAVerifier.GetEmprunteur() != null)
            {
                return true;
            }

            return false;
        }
    }
}
