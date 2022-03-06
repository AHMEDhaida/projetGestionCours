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
    public partial class FormEnseignant : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;
        int ID;
        public FormEnseignant()
        {
            InitializeComponent();
            dispay();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {

            if (txt_Name.Text == "" || txt_Prenom.Text == "" || txt_N.Text == "" || txt_IdUser.Text == "" || txt_sexe.Text == "" || txt_Age.Text == "" || txt_Grade.Text == "")
            {
                MessageBox.Show(" Please Provide Details!");

            }
            else
            {
                Enseignant enseignant = new Enseignant();
                enseignant.NEnseignant = txt_N.Text;
                enseignant.Age = int.Parse(txt_Age.Text);
                enseignant.NomEnseignant = txt_Name.Text;
                enseignant.PrenomEnseignant=txt_Prenom.Text;
                enseignant.Sexe = txt_sexe.Text;
                enseignant.IdUser = txt_IdUser.Text;
                enseignant.Grade = txt_Grade.Text;  



                // Inserer à la base
                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.InsertEnseignant(enseignant);

                MessageBox.Show(" Record Inserted Successfully ");
                clear();
                dispay();

            }
        }

    

    public void clear()
        {
            txt_Age.Text = null;
            txt_Grade.Text = null;
            txt_IdUser.Text = null; 
            txt_N.Text = null;
            txt_Name.Text = null;   
            txt_Prenom.Text = null; 
            txt_sexe.Text = null;   
            
        }
        public void dispay()
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            BDprojetGestionCours dbconnect = new BDprojetGestionCours();
            adpt = dbconnect.ListEnseignant();
            adpt.Fill(dt);
            grid_Enseignant.DataSource = dt;
        }

        private void grid_Enseignant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(grid_Enseignant.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_N.Text = grid_Enseignant.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Name.Text = grid_Enseignant.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Prenom.Text = grid_Enseignant.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Grade.Text = grid_Enseignant.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_IdUser.Text = grid_Enseignant.Rows[e.RowIndex].Cells[5].Value.ToString();
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (txt_Name.Text == "" || txt_Prenom.Text == "" || txt_N.Text == "" || txt_IdUser.Text == "" || txt_sexe.Text == "" || txt_Age.Text == "" || txt_Grade.Text == "")
            {
                MessageBox.Show("Please Provide Details!");

            }
            else
            {
                Enseignant enseignant = new Enseignant();
                enseignant.NEnseignant = txt_N.Text;
                enseignant.Age = int.Parse(txt_Age.Text);
                enseignant.NomEnseignant = txt_Name.Text;
                enseignant.PrenomEnseignant = txt_Prenom.Text;
                enseignant.Sexe = txt_sexe.Text;
                enseignant.IdUser = txt_IdUser.Text;
                enseignant.Grade = txt_Grade.Text;



                // Inserer à la base
                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.UpdateEnseignant(enseignant, ID);

                MessageBox.Show("  updated Successfully ");
                clear();
                dispay();

            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "" || txt_Prenom.Text == "" || txt_N.Text == "" || txt_IdUser.Text == "" || txt_sexe.Text == "" || txt_Age.Text == "" || txt_Grade.Text == "")
            {
                MessageBox.Show("Please Provide Details!");

            }
            else
            {

                // Inserer à la base
                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.DeleteEnseignant(ID);

                MessageBox.Show("  Deleted  Successfully! ");
                clear();
                dispay();

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
