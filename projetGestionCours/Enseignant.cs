using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGestionCours
{
    internal class Enseignant
    {
        private string nenseignant;
        private string nomEnseignant;
        private string prenomEnseignant;
        private string sexe;
        private string grade;
        private int age;
        private string idUser;

        public Enseignant() { }


        public string NEnseignant { get { return nenseignant; } set { nenseignant = value;} }
        public string PrenomEnseignant { get { return prenomEnseignant; } set { prenomEnseignant = value; } }
        public string Sexe { get { return sexe;} set { sexe = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string IdUser { get { return idUser; } set { idUser = value; } } 
        public  string  Grade { get { return grade; } set { grade = value; } } 
        public string   NomEnseignant { get { return nomEnseignant; } set { nomEnseignant = value; } }
    }
}
