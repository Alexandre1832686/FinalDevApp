using System;

namespace FinalDevApp
{
    public abstract class Document : IComparable<Document>
    {
        string titre;
        string auteur;
        Membre emprunteur;
        Membre[] listeAttente;

        public int CompareTo(Document obj)
        {
            if (obj.GetTitre() == this.GetTitre())
            {
                return 0;
            }

            return 1;
        }

        public bool estDisponible()
        {
            if (emprunteur == null)
            {
                return true;
            }

            return false;
        }

        public string GetTitre()
        {
            return titre;
        }

        public void SetTitre(string value)
        {
            titre = value;
        }

        public string GetAuteur()
        {
            return auteur;
        }

        public void SetAuteur(string value)
        {
            auteur = value;
        }

        public Membre GetEmprunteur()
        {
            return emprunteur;
        }

        public void SetEmprunteur(Membre value)
        {
            emprunteur = value;
        }

        public Membre[] GetListeAttente()
        {
            return listeAttente;
        }

        public Document(string titre, string auteur)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.emprunteur = null;
            this.listeAttente = new Membre[2];
        }

        public abstract string Description();

        public bool AjouterMembreListeAttente(Membre ajout)
        {
            if (listeAttente[0] == null)
            {
                listeAttente[0] = ajout;
                return true;
            }
            else if (listeAttente[1] == null)
            {
                listeAttente[1] = ajout;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EnleverMembreListeAttente(Membre retrait)
        {
            if(retrait.GetNom() == listeAttente[0].GetNom())
            {
                listeAttente[0] = null;
                if (listeAttente[1] != null)
                {
                    listeAttente[0] = listeAttente[1];
                    listeAttente[1] = null;
                }


                return true;
            }
            else if (retrait.GetNom() == listeAttente[1].GetNom())
            {
                listeAttente[1] = null;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
