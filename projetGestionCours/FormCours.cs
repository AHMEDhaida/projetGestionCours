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
    public partial class FormCours : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;
        int ID;
        public FormCours()
        {
            InitializeComponent();
            showdataClass();
            DisplayData();
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
            cmb_ClassName.DisplayMember = "name";
            cmb_ClassName.ValueMember = "Id";
            cmb_ClassName.DataSource = dt;
            
        }

        public void showdataClassID(int ClassID)
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            BDprojetGestionCours dbconnect = new BDprojetGestionCours();
            adpt = dbconnect.showdataClassID(ClassID);
            adpt.Fill(dt);

            DataRow Filaa = dt.NewRow();
            Filaa["name"] = "Select classe";
            cmb_ClassID.DisplayMember = "Id";
            cmb_ClassID.ValueMember = "Id";
            cmb_ClassID.DataSource = dt;
            
        }


        private void cmb_ClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ClassName.SelectedValue.ToString() != null)
            {
                String ClassID = cmb_ClassName.SelectedValue.ToString();
                showdataClassID(int.Parse(ClassID));
            }

        }
        private void DisplayData()
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            BDprojetGestionCours dbconnect = new BDprojetGestionCours();
            adpt = dbconnect.ListCours();
            adpt.Fill(dt);
            grid_Course.DataSource = dt;
        }
        //Clear Data  
        private void ClearData()
        {
            txt_CourseName.Text = "";
            date_CourseStart.Text = "";
            date_CourseEnd.Text = "";
            txt_CourseTiming.Text = "";
            cmb_ClassName.Text = "";
            cmb_ClassID.Text = "";
       

            ID = 0;
        }


        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_CourseName.Text != "" && cmb_ClassID.Text != "")
            {

                Cours cours = new Cours();  
                cours.CourseName = txt_CourseName.Text;
                cours.ClassID  = int.Parse(cmb_ClassID.SelectedValue.ToString());
                cours.CourseEnd = date_CourseEnd.Text;
                cours.CourseStart = date_CourseStart.Text;
                cours.CourseTiming = txt_CourseTiming.Text;
                cours.ClassName = cmb_ClassName.SelectedValue.ToString();





                // Inserer à la base
                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.InsertCours(cours);

                MessageBox.Show("  Record Inserted Successfully ");
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

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (txt_CourseName.Text != "" && cmb_ClassID.Text != "")
            {

                Cours cours = new Cours();
                cours.CourseName = txt_CourseName.Text;
                cours.ClassID = int.Parse(cmb_ClassID.SelectedValue.ToString());
                cours.CourseEnd = date_CourseEnd.Text;
                cours.CourseStart = date_CourseStart.Text;
                cours.CourseTiming = txt_CourseTiming.Text;
                cours.ClassName = cmb_ClassName.SelectedValue.ToString();





                // Inserer à la base
                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.UpdateCours(cours, ID);

                MessageBox.Show("  Updated Successfully ");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }

        private void grid_Course_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(grid_Course.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_CourseName.Text = grid_Course.Rows[e.RowIndex].Cells[1].Value.ToString();
            date_CourseStart.Text = grid_Course.Rows[e.RowIndex].Cells[2].Value.ToString();
            date_CourseEnd.Text = grid_Course.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_CourseTiming.Text = grid_Course.Rows[e.RowIndex].Cells[4].Value.ToString();
            

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (txt_CourseName.Text != "" && cmb_ClassID.Text != "")
            {

               
                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.DeleteCours(ID);

                MessageBox.Show("  Deleted Successfully ");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }
    }
}
