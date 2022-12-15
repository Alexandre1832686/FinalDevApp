using System;
using System.Collections.Generic;
using FinalDevApp;
using System.IO;

namespace ProjetQuiUtiliseLaDll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tests pour fonctions de la dll");
            Console.WriteLine("Audio : " + testAudio());
            Console.WriteLine("Bibliothèque : " + testBibli());
            Console.WriteLine("Document : " + testDocument());
            Console.WriteLine("Livre : " + testMembre());
            Console.WriteLine("Repertoire : " + testRepertoire());
           


            Console.ReadKey();
        }
        static bool testAudio()
        {
            Audio audio = new Audio("", -1000, "", "", "moi");
            if (audio.GetAuteur() != "moi")
            {
                return false;
            }

            return true;
        }
        static bool testBibli()
        {
            Biblioteque normal = new Biblioteque("normal");
            Biblioteque perso = new Biblioteque("perso", 15);
            Biblioteque petite = Biblioteque.CréerPetiteBiblioteque("petite");
            Biblioteque moyenne = Biblioteque.CréerMoyenneBiblioteque("moyenne");
            Biblioteque grande = Biblioteque.CréerGrandeBiblioteque("grande");

            if (normal.GetMembres().Length != 10)
            {
                return false;
            }

            if (perso.GetMembres().Length != 15)
            {
                return false;
            }

            if (petite.GetMembres().Length != 10)
            {
                return false;
            }

            if (moyenne.GetMembres().Length != 100)
            {
                return false;
            }

            if (grande.GetMembres().Length != 500)
            {
                return false;
            }



            Membre monMembre = new Membre("alex");
            Membre monMembre2 = new Membre("alex2");
            Document doc = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul", "paul");
            Biblioteque bibli = new Biblioteque("labibli");


            if (!bibli.AjouterMembre(monMembre))
            {
                return false;
            }
            if (!bibli.AjouterMembre(monMembre2))
            {
                return false;
            }

            if (bibli.NotifierRetour(doc))
            {
                return false;
            }

            if (!bibli.NotifierEmprunt(monMembre.GetNom(), doc))
            {
                return false;
            }

            //suposer pas marcher et retourner false
            if (bibli.NotifierEmprunt(monMembre2.GetNom(), doc))
            {
                return false;
            }

            if (doc.GetListeAttente()[0] != monMembre2)
            {
                return false;
            }


            if (!bibli.NotifierRetour(doc))
            {
                return false;
            }

            if (doc.GetEmprunteur() != monMembre2)
            {
                return false;
            }

            Biblioteque bib = new Biblioteque("bibli");

            for (int i = 0; i < 10; i++)
            {
                Membre monMembre3 = new Membre("alex");
                if (!bib.AjouterMembre(monMembre))
                {
                    return false;
                }
            }

            Membre monMembre4 = new Membre("alex2");

            if (bib.AjouterMembre(monMembre2))
            {
                return false;
            }



            Biblioteque biblio = new Biblioteque("bibli cool");
            Membre sujet = null;

            for (int i = 0; i < 10; i++)
            {
                Membre monMembre5 = new Membre("alex" + i);

                if (i == 2)
                {
                    sujet = monMembre5;
                }

                if (!biblio.AjouterMembre(monMembre5))
                {
                    return false;
                }
            }

            if (biblio.TrouverMembre(sujet.GetNom()) != sujet)
            {
                return false;
            }


            Membre sujet2 = new Membre("bwipo");



            try
            {
                biblio.TrouverMembre(sujet2.GetNom());
            }
            catch (MembreNotFoundException e)
            {
                return true;
            }

            return false;
        }
        static bool testDocument()
        {
            Document doc = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul", "paul");
            Document doc2 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul", "paul");
            Document doc3 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul2", "paul");


            if (doc.CompareTo(doc2) != 0)
            {
                return false;
            }

            if (doc.CompareTo(doc3) == 0)
            {
                return false;
            }
        

        
            Document docu = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul", "paul");
            Membre membre = new Membre("alex");
            Membre membre2 = new Membre("alex1");
            Membre membre3 = new Membre("alex2");
            Membre membre4 = new Membre("alex3");


            if (!docu.AjouterMembreListeAttente(membre))
            {
                return false;
            }
            if (!docu.AjouterMembreListeAttente(membre2))
            {
                return false;
            }
            if (!docu.AjouterMembreListeAttente(membre3))
            {
                return false;
            }
            if (docu.AjouterMembreListeAttente(membre4))
            {
                return false;
            }


            if (!docu.EnleverMembreListeAttente(membre2))
            {
                return false;
            }
            if (!docu.EnleverMembreListeAttente(membre3))
            {
                return false;
            }

            if (!docu.AjouterMembreListeAttente(membre3))
            {
                return false;
            }
            if (!docu.AjouterMembreListeAttente(membre4))
            {
                return false;
            }

            return true;
        }
        static bool testMembre()
        {
            Membre membre1 = new Membre("a");
            Membre membre2 = new Membre("b");
            Membre membre3 = new Membre("c");
            Membre membre4 = new Membre("d");

            if (membre4.GetNoMembre() != membre1.GetNoMembre() + 3)
            {
                return false;
            }

            Membre membre5 = new Membre("a");
            Document doc = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul", "paul");
            Document doc2 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul4", "paul");
            Document doc3 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul3", "paul");
            Document doc4 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul2", "paul");

            membre5.AjouterDocument(doc);
            membre5.AjouterDocument(doc2);
            membre5.AjouterDocument(doc3);

            if (membre5.AjouterDocument(doc4))
            {
                return false;
            }

            if (!membre5.RetirerDocument(doc3))
            {
                return false;
            }

            if (!membre5.AjouterDocument(doc4))
            {
                return false;
            }

            return true;
        }
        static bool testRepertoire()
        {
            string fileName = "BD.txt";
            string path = "../../../../" + fileName;


            if (!File.Exists(path))
            {
                return false;
            }


            List<Document> list = new List<Document>();
            list = Repertoire.ChargerDocuments(fileName);


            if (list[0].GetTitre() != "Geronimo")
            {
                return false;
            }


            if(fonction1Pourrepertoire() && fonction2Pourrepertoire())
            {
                return true;
            }


            return false;
        }

        static bool fonction1Pourrepertoire()
        {
            List<Document> list3 = new List<Document>();
            try
            {
                list3 = Repertoire.ChargerDocuments("BD2.txt");
            }
            catch (EnregistrementDocumentErrorException e)
            {
                return true;
            }


            return false;
        }
        static bool fonction2Pourrepertoire()
        {
            Document doc = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul", "paul");
            Document doc2 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul2", "paul");
            Document doc3 = new Livre("paul's editor inc", new System.DateTime(), 4, "bien", "45165166", "Le livre de paul3", "paul");
            List<Document> list = new List<Document>();
            list.Add(doc);
            list.Add(doc2);
            list.Add(doc3);

            Repertoire r = new Repertoire(list, "monRep");

            if (r.TrouverDocument("Le livre de paul", "paul") != doc)
            {
                return false;
            }

            try
            {
                r.TrouverDocument("Le livre de pauline", "pauline");
            }
            catch (DocumentNotFoundException e)
            {
                return true;
            }

            return false;
        }
    }
}
