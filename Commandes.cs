using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace le_cantine
{
    class Commandes
    {

        public static DataTable GetAllCommande()
        {
            return BDD.SelectDatatable("SELECT * FROM commande");
        }

        public static void UpdateCommande(string Id_Commande, string Date_Commande, string Prix_Total)
        {
            string requete = $"UPDATE commande SET Date_Commande = '{Date_Commande}', Prix_Total = '{Prix_Total}' WHERE Id_Commande = '{Id_Commande}'";

            BDD.ExecuteQuery(requete);
        }
        public static int CreateCommande(string Date_Commande, string Prix_Total, string id_utilisateur , string id_table)
        {
            string requete = $"INSERT INTO commande (Date_Commande, Prix_Total, id_utilisateur , id_table) VALUES '{Date_Commande}', '{Prix_Total}' , '{id_utilisateur}' , '{id_table}')";
            int result = BDD.ExecuteQuery(requete);
            return result;
        }
    }
}
