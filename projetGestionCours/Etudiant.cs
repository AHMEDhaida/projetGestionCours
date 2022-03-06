using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGestionCours
{
    internal class Etudiant
    {

        // Les champs 
        private string matricule;
        private string nom;
        private string prenom;
        private string classe;
        private string dateN;
        private string adresse;
        private string email;

        public Etudiant() { }

        public string Matricule { get { return matricule; } set { matricule = value; } }
        public string Nom { get { return nom; } set { nom = value; } }

        public string Prenom { get { return prenom; } set { prenom = value; } }

        public string Classe { get { return classe; } set { classe = value; } }

        public string DateN { get { return dateN; } set { dateN = value; } }

        public string Adresse { get { return adresse; } set { adresse = value; } }

       public string Email { get { return email; } set { email = value; } }
    }
}
