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
    public partial class FormUser : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;
        int ID;
        public FormUser()
        {
            InitializeComponent();
            dispay();
        }


        public void clear()
        {
            txt_UserName.Text = null;
            txt_Password.Text = null;

        }
        public void dispay()
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            BDprojetGestionCours dbconnect = new BDprojetGestionCours();
            adpt = dbconnect.ListUser();
            adpt.Fill(dt);
            grid_User.DataSource = dt;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text != "" && txt_Password.Text != "")
            {

                User user = new User();
                user.Username = txt_UserName.Text;
                user.Password = txt_Password.Text;

                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.InsertUser(user);

                MessageBox.Show("Record Inserted Successfully");
                clear();
                dispay();
            }
            else
            {
                MessageBox.Show("Please Provide Complete Details !");
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
            if (txt_UserName.Text != "" && txt_Password.Text != "")
            {

                User user = new User();
                user.Username = txt_UserName.Text;
                user.Password = txt_Password.Text;

                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.UpdateUser(user,ID);

                MessageBox.Show("Updated Successfully");
                clear();
                dispay();
            }
            else
            {
                MessageBox.Show("Please Provide Complete Details !");
            }
        }

        private void grid_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(grid_User.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_UserName.Text = grid_User.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Password.Text = grid_User.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text != "" && txt_Password.Text != "")
            {

                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                dbconnect.DeleteUser(ID);

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
