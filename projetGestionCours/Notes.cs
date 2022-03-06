using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGestionCours
{
    internal class Notes
    {
        private string numero_In;
        private string nom_Etudiant;
        private string module;
        private int note;

        public string Numero_In { get { return numero_In; } set { numero_In = value; } }
        public string Module { get { return module; } set { module = value; } }
        public int Note { get { return note; } set { note = value; } }
        public string Nom_Etudiant { get { return nom_Etudiant;} set { nom_Etudiant = value;} }
    }
}
