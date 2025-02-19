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


        public static MySqlConnection GetConnection()
        {
            if (maConnexion == null)
            {
                maConnexion = new MySqlConnection(chaineConnexion);
            }
            return maConnexion;
        }


        public static void OpenConnection()
            {
                if (maConnexion == null)
                    maConnexion = GetConnection();

                if (maConnexion.State == System.Data.ConnectionState.Closed)
                    maConnexion.Open();
            }

            public static void CloseConnection()
            {
                if (maConnexion != null && maConnexion.State == System.Data.ConnectionState.Open)
                {
                    maConnexion.Close();
                }
            }

            public static int ExecuteQuery(string query)
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, maConnexion);
                int result = cmd.ExecuteNonQuery(); // exe update delete insert
                CloseConnection();
                return result;
            }
            public static int ExecuteQuery2(string query)
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, maConnexion);
                MySqlDataReader rdr = cmd.ExecuteReader(); // exe uniquement select
                if (rdr.Read())
                {
                    int result = Convert.ToInt16(rdr.GetValue("last_id"));
                    CloseConnection();
                    return result;
                }
                else
                {
                    CloseConnection();
                    return -10;
                }
            }
            public static DataTable ExecuteSelectToDataTable(string query)
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, maConnexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                CloseConnection();
                return dataTable;
            }


            public static MySqlDataReader ExecuteSelect(string query)
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, maConnexion);
                return cmd.ExecuteReader();
            }


            ///////////////////////////



            
      
/////////////////////////////// faire un booléan ( 1 admin , 0  user ) et d'apres juliann (1 OU 0 ADMIN ET 1 OU 0 USER)//////////////////////

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

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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


        public static DataTable GetAllTables()
        {
            return SelectDatatable("SELECT Id_Table, Numero, Capapcite, Statut FROM Tables");
        }
    }
}
