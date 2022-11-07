using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDevApp
{
    internal class Biblioteque
    {
        //variables
        Repertoire leRepertoire;
        string nom;
        Membre[] lesMembre;
        int nbMembresActuellement;

        //retourne le nom de la biblioteque
        public string GetNom()
        {
            return nom;
        }
        //retourne les membre de la bibliotèque
        public Membre[] GetMembres()
        {
            return lesMembre;
        }

        //Constructeur
        public Biblioteque(string nomBiblioteque)
        {
            nbMembresActuellement = 0;
            nom = nomBiblioteque;
            lesMembre = new Membre[10];
        }



        #region FonctionAjouté
            //CONSTRUCTEUR AJOUTÉ - permet de choisir le nombre de Membre Maximum
            public Biblioteque(string nomBiblioteque, int nbMembreMax)
            {
                nbMembresActuellement = 0;
                nom = nomBiblioteque;
                lesMembre = new Membre[nbMembreMax];
            }


            //FONCTION AJOUTÉ - permet de créer une bibliotèque avec 500 membres 
            public Biblioteque CréerGrandeBiblioteque(string nom)
            {
                return new Biblioteque(nom, 500);
            }
            //FONCTION AJOUTÉ - permet de créer une bibliotèque avec 100 membres
            public Biblioteque CréerMoyenneBiblioteque(string nom)
            {
                return new Biblioteque(nom, 100);
            }
            //FONCTION AJOUTÉ - permet de créer une bibliotèque avec 10 membres
            public Biblioteque CréerPetiteBiblioteque(string nom)
            {
                return new Biblioteque(nom, 10);
            }
        #endregion




        //retourne true si le livre est disponible et lui attribue.
        //si le livre n'est pas dispo, retourne false et met le membre en liste d'attente.
        public bool NotifierEmprunt(string nomMembre, Document leDocument)
        {

        }

        public bool NotifierRetour(Document leDocument)
        {

        }

        //vas chercher un membre dans son tableau de membres par son nom. renvoie null si ne trouve pas. renvoie le membre si trouve
        public Membre TrouverMembre(string nom)
        {
            if(nom != null)
            {
                foreach(Membre m in lesMembre)
                {
                    if(m.GetNom() == nom)
                    {
                        return m;
                    }
                }
            }
            
            return null;
            
        }

        //FONCTION MODIFIER -
        //regarde si il y a de la place pour un nouveau membre, si oui l'ajoute et augmente le nombre de membres actuel.
        //la fonction vas retourner un bool pour savoir si le membre à bien été ajouté.
        public bool AjouterMembre(Membre nouveau)
        {
            if(nbMembresActuellement < lesMembre.Length)
            {
                lesMembre[nbMembresActuellement] = nouveau;
                nbMembresActuellement++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AjouterListeAttente(Membre leMembre, Document leDoc)
        {

        }
    }
}
