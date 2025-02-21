using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace le_cantine
{
    internal class Tables
    {
        public static DataTable GetAllTables()
        {
            return BDD.SelectDatatable("SELECT Id_Table, Numero, Capapcite, Statut FROM Tables");
        }



        public static int CreateTable(string numero, string capacite, string statut)
        {
                string requete = $"INSERT INTO Tables (Numero, Capapcite, Statut) VALUES ('{numero}', '{capacite}', '{statut}')";
                int result = BDD.ExecuteQuery(requete);
                return result;
        }

        public static void UpdateTable(string Id_Table, string numero, string capacite, string statut)
        {
            string requete = $"UPDATE Tables SET Numero = '{numero}', Capapcite = '{capacite}', Statut = '{statut}' WHERE Id_Table = '{Id_Table}'";
            
            BDD.ExecuteQuery(requete); 
        }

        public static void DeleteTable(string Id_Table)
        {
            string requete = $"DELETE FROM Tables WHERE Id_Table = '{Id_Table}'";
            BDD.ExecuteQuery(requete);
        }

    }
}
