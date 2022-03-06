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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show(" Please Enter User Name and Password ");

            }
            else
            {


                // Inserer à la base
                BDprojetGestionCours dbconnect = new BDprojetGestionCours();
                bool v ;
                v = dbconnect.Login(txtUserName.Text, txtPassword.Text);

                if (v)
                {
                    MessageBox.Show(" You  have  Successfully logged in  ");
                    Main objMain = new Main();
                    objMain.Show();
                    this.Hide();
                  


                }
                else
                {
                    MessageBox.Show(" Please Check User Name and Password ");
                }



            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
