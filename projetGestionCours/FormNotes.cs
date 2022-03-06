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
    public partial class FormNotes : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;
        int ID;
        public FormNotes()
        {
            InitializeComponent();
            showdataMatricule();
            showdataCours();


        }

         public void showdataCours()
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            BDprojetGestionCours dbconnect = new BDprojetGestionCours();
            adpt = dbconnect.showdataCours();
            adpt.Fill(dt);

            DataRow Filaa = dt.NewRow();
            Filaa["CourseName"] = "Select course";
            com_Module.DisplayMember = "CourseName";
            com_Module.ValueMember = "id";
            com_Module.DataSource = dt;

        }


        public void showdataMatricule()
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            BDprojetGestionCours dbconnect = new BDprojetGestionCours();
            adpt = dbconnect.showdataMatricule();
            adpt.Fill(dt);

            DataRow Filaa = dt.NewRow();
            Filaa["Matricule"] = "Select etudiant";
            cmb_Matricule.DisplayMember = "Matricule";
            cmb_Matricule.ValueMember = "ID";
            cmb_Matricule.DataSource = dt;

        }

        public void showdataMatriculeID(int ClassID)
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            BDprojetGestionCours dbconnect = new BDprojetGestionCours();
            adpt = dbconnect.showdataMatricule(ClassID);
            adpt.Fill(dt);

            DataRow Filaa = dt.NewRow();
            Filaa["Nom"] = "Select etudiant";
            comNom.DisplayMember = "Nom";
            comNom.ValueMember = "Nom";
            comNom.DataSource = dt;

        }

        private void com_Module_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void DisplayData(string matricule)
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            BDprojetGestionCours dbconnect = new BDprojetGestionCours();
            adpt = dbconnect.ListNote(matricule);
            adpt.Fill(dt);
            grd_Note.DataSource = dt;
        }
        //Clear Data  
        private void ClearData()
        {
            cmb_Matricule.Text = "";
            cmb_Matricule.Text = "";
            comNom.Text = "";
            txt_Note.Text = "";
           

            ID = 0;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (cmb_Matricule.Text != "" && com_Module.Text != "" && txt_Note.Text != "")
            {

                Notes notes = new Notes();
                notes.Nom_Etudiant = comNom.Text;
                notes.Note = int.Parse(txt_Note.Text);
                notes.Module = com_Module.Text;
                notes.Numero_In = cmb_Matricule.Text;






                // Inserer à la base
                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.InsertNote(notes);

                MessageBox.Show("  Record Inserted Successfully ");
                DisplayData(cmb_Matricule.Text);
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void comNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Matricule.SelectedValue.ToString() != null)
            {
                string ClassID = cmb_Matricule.SelectedValue.ToString();
                showdataMatriculeID(int.Parse(ClassID));
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (cmb_Matricule.Text != "" && com_Module.Text != "" && txt_Note.Text != "")
            {

                Notes notes = new Notes();
                notes.Nom_Etudiant = comNom.Text;
                notes.Note = int.Parse(txt_Note.Text);
                notes.Module = com_Module.Text;
                notes.Numero_In = cmb_Matricule.Text;






                // Inserer à la base
                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.UpdateNote(notes, ID);

                MessageBox.Show("  Updated Successfully ");
                DisplayData(cmb_Matricule.Text);
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void grd_Note_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(grd_Note.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmb_Matricule.Text = grd_Note.Rows[e.RowIndex].Cells[1].Value.ToString();
            comNom.Text = grd_Note.Rows[e.RowIndex].Cells[2].Value.ToString();
            com_Module.Text = grd_Note.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Note.Text = grd_Note.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
