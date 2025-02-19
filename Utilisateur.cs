using le_cantine;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Data;

namespace le_cantine
{

    public class Utilisateur
    {


        public static bool UserExistDeja(string Email, string mdp)
        {

            string requete = $"SELECT * FROM UTILISATEUR WHERE Email = '{Email}' AND MotDePasse = '{mdp}'";

            MySqlDataReader reader = BDD.ExecuteSelect(requete);

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }


        public static int CreateUser(string Nom, string MotDePasse, string Email, string Role)
        {
            string requete = $"INSERT INTO Utilisateur (Nom, MotDePasse, Email, Role) VALUES ('{Nom}', '{MotDePasse}', '{Email}', '{Role}')";

            int result = BDD.ExecuteQuery(requete);

            return result;
        }


        public static void UpdateUser(string Id_Utilisateur, string nom, string email, string mdp, string role)
        {
                string requete = $"UPDATE Utilisateur SET Nom = '{nom}', Email = '{email}',  MotDePasse = '{mdp}', Role = '{role}' WHERE Id_Utilisateur = '{Id_Utilisateur}'";

                BDD.ExecuteQuery(requete);
        }



        public static bool ValidateTextBoxes(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Un ou plusieurs champs sont vides. Veuillez les remplir.");
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateComboBoxes(params ComboBox[] comboBoxes)
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (string.IsNullOrWhiteSpace(comboBox.Text))
                {
                    MessageBox.Show("Un ou plusieurs champs sont vides. Veuillez les remplir.");
                    return false;
                }
            }
            return true;
        }

        public static DataTable GetAllUsers()
        {
            return BDD.SelectDatatable("SELECT * FROM Utilisateur");
        }


        public static void DeleteUser(string Id_Utilisateur)
        {
            string requete = $"DELETE FROM Utilisateur WHERE Id_Utilisateur = '{Id_Utilisateur}'";
            BDD.ExecuteQuery(requete);
        }


    }
}


