using MySql.Data.MySqlClient;
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
    public partial class FormEtudiant : Form
    {

        MySqlDataAdapter adpt;
        DataTable dt;
        int ID;
        public FormEtudiant()
        {
            InitializeComponent();
            DisplayData();
            showdataClass();
        }

        public void showdataClass()
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            BDprojetGestionCours dbconnect = new BDprojetGestionCours();
            adpt = dbconnect.showdataClass();
            adpt.Fill(dt);

            DataRow Filaa = dt.NewRow();
            Filaa["name"] = "Select classe";
            cmb_Class.DisplayMember = "name";
            cmb_Class.ValueMember = "Id";
            cmb_Class.DataSource = dt;

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_StudentFirstName.Text != "" && txt_StudentEmailID.Text != "" && txt_StudentMatricule.Text != "" )
            {

                Etudiant etudiant = new Etudiant();

                etudiant.Matricule = txt_StudentMatricule.Text;
                etudiant.Nom = txt_StudentFirstName.Text;
                etudiant.Prenom = txt_StudentLastName.Text;
                etudiant.Classe = cmb_Class.Text;
                etudiant.Adresse = txt_StudentAddress.Text;
                etudiant.Email = txt_StudentEmailID.Text;
                etudiant.DateN = Student_DOB.Text;

                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.InsertEtudiant(etudiant);
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void ClearData()
        {
            txt_StudentFirstName.Text = "";
            txt_StudentLastName.Text = "";
            txt_StudentMatricule.Text = "";
            Student_DOB.Text = "";
            cmb_Class.Text = "";
            txt_StudentAddress.Text = "";
            txt_StudentEmailID.Text = "";
           
            ID = 0;

           
        }

        private void DisplayData()
        {

            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            BDprojetGestionCours dbconnect = new BDprojetGestionCours();
            adpt = dbconnect.ListEtudiant();
            adpt.Fill(dt);
            grid_Student.DataSource = dt;

        }

        private void grid_Student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(grid_Student.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_StudentMatricule.Text = grid_Student.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_StudentFirstName.Text = grid_Student.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_StudentLastName.Text = grid_Student.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmb_Class.Text = grid_Student.Rows[e.RowIndex].Cells[4].Value.ToString();
            Student_DOB.Text = grid_Student.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_StudentAddress.Text = grid_Student.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_StudentEmailID.Text = grid_Student.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_StudentFirstName.Text != "" && txt_StudentEmailID.Text != "" && txt_StudentMatricule.Text != "")
            {

                Etudiant etudiant = new Etudiant();

                etudiant.Matricule = txt_StudentMatricule.Text;
                etudiant.Nom = txt_StudentFirstName.Text;
                etudiant.Prenom = txt_StudentLastName.Text;
                etudiant.Classe = cmb_Class.Text;
                etudiant.Adresse = txt_StudentAddress.Text;
                etudiant.Email = txt_StudentEmailID.Text;
                etudiant.DateN = Student_DOB.Text;

                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.UpdateEtudiant(etudiant,ID);
                MessageBox.Show("Updated Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_StudentFirstName.Text != "" && txt_StudentEmailID.Text != "" && txt_StudentMatricule.Text != "")
            {

                Etudiant etudiant = new Etudiant();

                etudiant.Matricule = txt_StudentMatricule.Text;
                etudiant.Nom = txt_StudentFirstName.Text;
                etudiant.Prenom = txt_StudentFirstName.Text;
                etudiant.Classe = cmb_Class.Text;
                etudiant.Adresse = txt_StudentAddress.Text;
                etudiant.Email = txt_StudentEmailID.Text;

                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.DeleteEtudiant(ID);

                MessageBox.Show("  Deleted  Successfully! ");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details !");
            }
        }
    }
}

