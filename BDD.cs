using System.Data;
using System.Data.SqlClient;  // Si tu utilises SQL Server
// using MySql.Data.MySqlClient;  // Si tu utilises MySQL
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace le_cantine
{
    public static class BDD
    {
        private static string chaineConnexion = "server=localhost;userid=root;mdp=;database=le_cantine";
        private static MySqlConnection maConnexion = null;

        
        public static bool GetConnexion()
        {
            try
            {
                maConnexion = new MySqlConnection(chaineConnexion);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool UserExistDeja(string Email, string mdp)
        {
            try
            {
                maConnexion.Open();

                string requete = $"SELECT * FROM UTILISATEUR WHERE Email = '{Email}' AND MotDePasse = '{mdp}'";

                MySqlCommand cmd = new MySqlCommand(requete, maConnexion);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                maConnexion.Close();
            }
        }

        /* public static bool UserExistDeja(string nomUtilisateur, string email)
         {
             try
             {
                 maConnexion.Open();
                 string requete = "SELECT COUNT(*) FROM UTILISATEURS WHERE NomUtilisateur = @nomUtilisateur OR Email = @email";
                 MySqlCommand cmd = new MySqlCommand(requete, maConnexion);
                 cmd.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                 cmd.Parameters.AddWithValue("@email", email);
                 int count = Convert.ToInt32(cmd.ExecuteScalar());

                 return count > 0; // Retourne true si l'utilisateur ou l'email existe déjà
             }
             catch (MySqlException e)
             {
                 MessageBox.Show(e.Message);
                 return false;
             }
             finally
             {
                 maConnexion.Close();
             }
         }
        */



        public static int CreateUser(string Nom, string MotDePasse, string Email, string Role)
        {
            try
            {
                maConnexion.Open();
                string requete = "INSERT INTO Utilisateur (Nom, MotDePasse, Email, Role) VALUES (@Nom, @MotDePasse, @Email, @Role)";
                MySqlCommand cmd = new MySqlCommand(requete, maConnexion);
                cmd.Parameters.AddWithValue("@Nom", Nom);
                cmd.Parameters.AddWithValue("@MotDePasse", MotDePasse);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Role", Role);

                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Code erreur MySQL pour "Duplicate entry"
                {
                    return -1; // Indique que l'utilisateur existe déjà
                }
                throw;
            }
            finally
            {
                maConnexion.Close();
            }
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

        public static string GetUserRole(string email, string motDePasse)
        {
            string role = null;

            maConnexion.Open();
            string requete = "SELECT Role FROM Utilisateur WHERE Email = @Email AND MotDePasse = @MotDePasse";
            MySqlCommand cmd = new MySqlCommand(requete, maConnexion);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@MotDePasse", motDePasse);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                role = result.ToString();
            }

            maConnexion.Close();
            return role;
        }


        public static DataTable SelectDatatable(string query)
        {
            maConnexion.Open();
            MySqlCommand cmd = new MySqlCommand(query, maConnexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            maConnexion.Close();
            return dt;
        }

        public static DataTable GetAllUsers()
        {
            return SelectDatatable("SELECT * FROM Utilisateur");
        }


        public static void UpdateUser(string id, string nom, string email, string mdp, string role)
        {
            try
            {
                maConnexion.Open();
                string query = @"UPDATE Utilisateur
                         SET Nom = @Nom,
                             Email = @Email,
                             MotDePasse = @MotDePasse,
                             Role = @Role
                         WHERE Id_Utilisateur = @Id_Utilisateur";

                MySqlCommand cmd = new MySqlCommand(query, maConnexion);
                cmd.Parameters.AddWithValue("@Id_Utilisateur", id);
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MotDePasse", mdp);
                cmd.Parameters.AddWithValue("@Role", role);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur SQL : " + ex.Message);
            }
            finally
            {
                maConnexion.Close();
            }
        }




        public static void DeleteUser(string id)
        {
            try
            {
                maConnexion.Open();
                string query = "DELETE FROM Utilisateur WHERE Id_Utilisateur = @id";
                MySqlCommand cmd = new MySqlCommand(query, maConnexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur SQL : " + ex.Message);
            }
            finally
            {
                maConnexion.Close();
            }
        }

        public static DataTable GetAllTables()
        {
            return SelectDatatable("SELECT Id_Table, Numero, Capapcite, Statut FROM Tables");
        }

        public static int CreateTable(string numero, string capacite, string statut)
        {
            try
            {
                maConnexion.Open();
                string requete = "INSERT INTO Tables (Id_Table, Numero, Capapcite, Statut) VALUES (UUID(), @Numero, @Capapcite, @Statut)";
                MySqlCommand cmd = new MySqlCommand(requete, maConnexion);
                cmd.Parameters.AddWithValue("@Numero", numero);
                cmd.Parameters.AddWithValue("@Capapcite", capacite);
                cmd.Parameters.AddWithValue("@Statut", statut);

                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur SQL : " + ex.Message);
                return 0;
            }
            finally
            {
                maConnexion.Close();
            }
        }


        public static void UpdateTable(string id, string numero, string capacite, string statut)
        {
            try
            {
                maConnexion.Open();
                string query = @"UPDATE Tables
                         SET Numero = @Numero,
                             Capapcite = @Capapcite,
                             Statut = @Statut
                         WHERE Id_Table = @Id_Table";

                MySqlCommand cmd = new MySqlCommand(query, maConnexion);
                cmd.Parameters.AddWithValue("@Id_Table", id);
                cmd.Parameters.AddWithValue("@Numero", numero);
                cmd.Parameters.AddWithValue("@Capapcite", capacite);
                cmd.Parameters.AddWithValue("@Statut", statut);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur SQL : " + ex.Message);
            }
            finally
            {
                maConnexion.Close();
            }
        }


        public static void DeleteTable(string id)
        {
            try
            {
                maConnexion.Open();
                string query = "DELETE FROM Tables WHERE Id_Table = @id";
                MySqlCommand cmd = new MySqlCommand(query, maConnexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur SQL : " + ex.Message);
            }
            finally
            {
                maConnexion.Close();
            }
        }



    }
}
