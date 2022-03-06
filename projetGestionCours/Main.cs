using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetGestionCours
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_TeacherRegistraion_Click(object sender, EventArgs e)
        {
            FormEnseignant formEnseignant = new FormEnseignant();
            formEnseignant.Show();
            this.Close();

        }

        private void btn_Class_Click(object sender, EventArgs e)
        {
            FormClasse formClasse = new FormClasse();   
            formClasse.Show();
            this.Close();
        }

        private void btn_UserRegistration_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_StudentRegistration_Click(object sender, EventArgs e)
        {
            FormEtudiant formEtudiant = new FormEtudiant(); 
            formEtudiant.Show();
            this.Close();
        }

        private void btn_Course_Click(object sender, EventArgs e)
        {
            FormCours formCours = new FormCours();
            formCours.Show();
            this.Close();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            FormNotes formNotes = new FormNotes();
            formNotes.Show();
            this.Close();
        }
    }
}
