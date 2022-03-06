using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetGestionCours
{
    internal class BDprojetGestionCours
    {

        private string user;
        private string password;
        private string dbName;
        private string server;
        private string sslMode;
        private MySqlConnection conn;
        MySqlDataAdapter adpt;
        MySqlDataAdapter adptLogin;

        public BDprojetGestionCours()
        {
            initilize();
        }
        // Créer la connexion à la base de données
        private void initilize()
        {
            user = "root";
            password = "";
            dbName = "bdprojetgestioncours";
            server = "localhost";
            sslMode = "none";





            string connexion = "SERVER=" + server + ";"
                + "DATABASE=" + dbName + ";"
                + "UID=" + user + ";"
                + "PASSWORD=" + password + ";"
                + "SslMode=" + sslMode + ";"
                ;

            conn = new MySqlConnection(connexion);
        }

        // ouvrir une connexion à la base de données client_ms
        private bool OpenConnexion()
        {
            try
            {
                conn.Open();
                return true;

            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Problème de connnexion !!");
                        break;
                    case 1045:
                        MessageBox.Show("Login ou Mot de pass incorrecte !");
                        break;
                }

                return false;
            }
        }



        public bool Login(string Username, string PassWord)
        {
            // définir la requête 
            string request = "SELECT * FROM loginusers WHERE U_Name='" + Username + "' and U_Pass='" + PassWord + "'";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                adptLogin = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adptLogin.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 0)
                {
                    return false;
                }


                this.conn.Close(); // fermer la session de connexion
            }

            return true;

        }


        public void InsertEnseignant(Enseignant e)
        {
            // définir la requête 
            string request = "INSERT INTO enseignant(NEnseignant, nomEnseignant, prenomEnseignant, sexe, grade, age, idUser)"
                + " VALUES('" + e.NEnseignant + "', '" + e.NomEnseignant + "', '" + e.PrenomEnseignant + "', '" + e.Sexe + "', '" + e.Grade + "', '" + e.Age + "', '" + e.IdUser + "')";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }
        }

        public void UpdateEnseignant(Enseignant e, int ID)
        {
            // définir la requête 
            string request = "UPDATE  enseignant SET NEnseignant='" + e.NEnseignant + "', nomEnseignant='" + e.NomEnseignant + "', prenomEnseignant='" + e.PrenomEnseignant + "', sexe= '" + e.Sexe + "', grade='" + e.Grade + "', age=" + e.Age + ", idUser='" + e.IdUser + "' WHERE Id = " + ID + " ";


            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }

        public void DeleteEnseignant(int ID)
        {
            // définir la requête 
            string request = "DELETE FROM enseignant WHERE id = " + ID + " ";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }
        public MySqlDataAdapter ListEnseignant()
        {

            string request = "SELECT Id, NEnseignant, nomEnseignant, prenomEnseignant, grade, idUser FROM enseignant";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }

        public void InsertClasse(Classe c)
        {
            // définir la requête 
            string request = "INSERT INTO classe(name, tim)"
                + " VALUES('" + c.Name + "', '" + c.Tim + "')";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }
        }

        public void UpdateClasse(Classe c, int ID)
        {
            // définir la requête 
            string request = "UPDATE  classe SET name='" + c.Name + "', tim='" + c.Tim + "' WHERE Id = " + ID + " ";


            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }

        public void DeleteClasse(int ID)
        {
            // définir la requête 
            string request = "DELETE FROM classe WHERE id = " + ID + " ";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }
        public MySqlDataAdapter ListClasse()
        {

            string request = "SELECT * FROM classe";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }
        public MySqlDataAdapter showdataClassID(int ClassID)
        {

            string request = "SELECT Id, name FROM classe  Where Id = "+ ClassID +"";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }

        public MySqlDataAdapter showdataClass()
        {

            string request = "SELECT Id, name FROM classe";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }


        public void InsertUser(User u)
        {
            // définir la requête 
            string request = "INSERT INTO loginusers(U_Name, U_Pass)"
                + " VALUES('" + u.Username + "', '" + u.Password + "')";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }
        }

        public void UpdateUser(User u, int ID)
        {
            // définir la requête 
            string request = "UPDATE  loginusers SET U_Name='" + u.Username + "', U_Pass='" + u.Password + "' WHERE U_ID = " + ID + " ";


            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }

        public void DeleteUser(int ID)
        {
            // définir la requête 
            string request = "DELETE FROM loginusers WHERE U_ID = " + ID + " ";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }
        public MySqlDataAdapter ListUser()
        {

            string request = "SELECT * FROM loginusers";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }



        public void InsertCours(Cours c)
        {
            // définir la requête 
            string request = "INSERT INTO course(CourseName,CourseStart,CourseEnd,CourseTiming,ClassName,ClassID)"
                + " VALUES('" + c.CourseName + "', '" + c.CourseStart + "', '" + c.CourseEnd + "', '" + c.CourseTiming + "', '" + c.ClassName + "', '" + c.ClassID + "')";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }
        }

        public void UpdateCours(Cours c, int ID)
        {
            // définir la requête 
            string request = "UPDATE  course SET CourseName='" + c.CourseName + "', CourseStart='" + c.CourseStart + "', CourseTiming='" + c.CourseTiming + "', ClassName= '" + c.ClassName + "', CourseEnd='" + c.CourseEnd + "', ClassID=" + c.ClassID + " WHERE Id = " + ID + " ";


            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }

        public void DeleteCours(int ID)
        {
            // définir la requête 
            string request = "DELETE FROM course WHERE id = " + ID + " ";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }
        public MySqlDataAdapter ListCours()
        {

            string request = "SELECT * FROM course";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }


        public MySqlDataAdapter showdataCours()
        {

            string request = "SELECT id, CourseName FROM course";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }



        public void InsertEtudiant(Etudiant e)
        {
            // définir la requête 
            string request = "INSERT INTO etudiant(Matricule, Nom, Prenom, Classe, DateN, Adresse, Email)"
                + " VALUES('" + e.Matricule + "', '" + e.Nom + "', '" + e.Prenom + "', '" + e.Classe + "', '" + e.DateN + "', '" + e.Adresse + "', '" + e.Email + "')";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }
        }

        public void UpdateEtudiant(Etudiant e, int ID)
        {
            // définir la requête 
            string request = "UPDATE  etudiant SET Matricule='" + e.Matricule + "', Nom='" + e.Nom + "', Prenom='" + e.Prenom + "', Classe= '" + e.Classe + "', DateN='" + e.DateN + "', Adresse='" + e.Adresse + "', Email='" + e.Email + "' WHERE id = " + ID + " ";


            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }

        public void DeleteEtudiant(int ID)
        {
            // définir la requête 
            string request = "DELETE FROM etudiant WHERE id = " + ID + " ";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }
        public MySqlDataAdapter ListEtudiant()
        {

            string request = "SELECT * FROM etudiant";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }

        public MySqlDataAdapter ListEtudiant(string matricule)
        {

            string request = "SELECT * FROM etudiant WHERE code = '" + matricule + "'";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }

        public MySqlDataAdapter showdataMatricule(int ID)
        {

            string request = "SELECT Nom, Matricule FROM etudiant  WHERE ID = " + ID + " ";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }
        public MySqlDataAdapter showdataMatricule()
        {

            string request = "SELECT ID, Matricule FROM etudiant";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }



        public void InsertNote(Notes n)
        {
            // définir la requête 
            string request = "INSERT INTO note(Numero_Inscription,Non_Etudiant,Nom_Module,Note)"
                + " VALUES('" + n.Numero_In + "', '" + n.Nom_Etudiant + "', '" + n.Module + "', '" + n.Note + "')";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }
        }

        public void UpdateNote(Notes n, int ID)
        {
            // définir la requête 
            string request = "UPDATE  note SET Numero_Inscription='" + n.Numero_In + "', Non_Etudiant='" + n.Nom_Etudiant + "', Nom_Module='" + n.Module + "', Note= '" + n.Note + "' WHERE Id = " + ID + " ";


            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }

        public void DeleteNote(int ID)
        {
            // définir la requête 
            string request = "DELETE FROM note WHERE id = " + ID + " ";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }
        public MySqlDataAdapter ListNote(string matricule)
        {

            string request = "SELECT * FROM note WHERE Numero_Inscription='" + matricule + "' ";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }




    }
}
