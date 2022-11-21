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
            throw new NotImplementedException();
        }

        public List<Document> GetListeEmprunts()
        {
            throw new NotImplementedException();
        }

        public Repertoire(List<Document> listeDocuments, string nomRepertoire)
        {
            this.listeDocuments = listeDocuments;
            this.nom = nomRepertoire;
        }

        public static List<Document> ChargerDocuments(string nomFichier)
        {
            FileStream f = new FileStream(nomFichier, FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            List<Document> documents = new List<Document>();
            
            string line;

            while ((line = s.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                switch(data[0])
                {
                    case "Livre":
                        Document monLivre = new Livre(data[1], DateTime.Parse(data[2]), Int32.Parse(data[3]), data[4], data[5], data[6], data[7]);
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
                        throw new Exception("premier mot n'est pas un type");
                        
                }
            }
            

            s.Close();
            f.Close();
            return documents;
        }

        public Document TrouverDocument(string titre, string auteur)
        {
            throw new NotImplementedException();
        }

        public bool AjouterDocument(Document nouveauDoc)
        {
            throw new NotImplementedException();
        }

        public bool suprimerDocument(Document docASuprimer)
        {
            throw new NotImplementedException();
        }

        public bool VerifierDisponibilite(Document docAVerifier)
        {
            throw new NotImplementedException();
        }
    }
}
