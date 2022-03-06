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
    public partial class FormClasse : Form
    {

        MySqlDataAdapter adpt;
        DataTable dt;
        int ID;
        public FormClasse()
        {
            InitializeComponent();
            dispay();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            txt_ClassTiming.Text = null;
            txt_ClassName.Text = null;

        }
        public void dispay()
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            BDprojetGestionCours dbconnect = new BDprojetGestionCours();
            adpt = dbconnect.ListClasse();
            adpt.Fill(dt);
            grd_Class.DataSource = dt;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_ClassName.Text != "" && txt_ClassTiming.Text != "")
            {

                Classe classe = new Classe();
                classe.Name = txt_ClassName.Text;
                classe.Tim = txt_ClassTiming.Text;

                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.InsertClasse(classe);

                MessageBox.Show("Record Inserted Successfully");
                clear();
                dispay();

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
            if (txt_ClassName.Text != "" && txt_ClassTiming.Text != "")
            {

                Classe classe = new Classe();
                classe.Name = txt_ClassName.Text;
                classe.Tim = txt_ClassTiming.Text;

                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.UpdateClasse(classe, ID);

                MessageBox.Show("Record updated Successfully");
                clear();
                dispay();

            }
            else
            {

                MessageBox.Show("Please Provide Details!");
            }
        }

        private void grd_Class_Click(object sender, EventArgs e)
        {

        }

        private void grd_Class_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(grd_Class.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_ClassName.Text = grd_Class.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ClassTiming.Text = grd_Class.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (txt_ClassName.Text != "" && txt_ClassTiming.Text != "")
            {

                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.DeleteClasse(ID);

                MessageBox.Show("Deleted Successfully");
                clear();
                dispay();

            }
            else
            {

                MessageBox.Show("Please Provide Details!");
            }

        }
    }
}
