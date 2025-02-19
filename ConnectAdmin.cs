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

namespace le_cantine
{
    public partial class ConnectAdmin : Form
    {
        public ConnectAdmin()
        {
            InitializeComponent();
            BDD.GetConnection();
            LoadUsers();
            LoadTables();
        }

        private void ConnectAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabModifUser_Click(object sender, EventArgs e)
        {

        }

        private void LoadUsers()
        {
            try
            {
                DataTable dt = Utilisateur.GetAllUsers(); // Récupère tous les utilisateurs depuis la BDD
                dataGridViewUsers.DataSource = dt; // Lier les données au DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des utilisateurs : " + ex.Message);
            }
        }

        private void btnModifierUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                string Id_Utilisateur = dataGridViewUsers.SelectedRows[0].Cells["Id_Utilisateur"].Value.ToString();
                string nom = dataGridViewUsers.SelectedRows[0].Cells["Nom"].Value.ToString();
                string email = dataGridViewUsers.SelectedRows[0].Cells["Email"].Value.ToString();
                string mdp = dataGridViewUsers.SelectedRows[0].Cells["MotDePasse"].Value.ToString();
                string role = dataGridViewUsers.SelectedRows[0].Cells["Role"].Value.ToString();

                Utilisateur.UpdateUser(Id_Utilisateur, nom, email, mdp, role);
                MessageBox.Show("Utilisateur mis à jour !");
                LoadUsers(); // Recharge les données
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier.");
            }
        }

        private void btnSupprimerUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                string id = dataGridViewUsers.SelectedRows[0].Cells["Id_Utilisateur"].Value.ToString();

                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    BDD.DeleteUser(id);
                    MessageBox.Show("Utilisateur supprimé !");
                    LoadUsers(); // Recharge les données
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
            }
        }

        private void btnAjouterUser_Click(object sender, EventArgs e)
        {
            // Boîte de dialogue pour récupérer les informations du nouvel utilisateur
            string nom = Microsoft.VisualBasic.Interaction.InputBox("Nom de l'utilisateur :", "Ajouter un utilisateur", "");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Email :", "Ajouter un utilisateur", "");
            string motDePasse = Microsoft.VisualBasic.Interaction.InputBox("Mot de passe :", "Ajouter un utilisateur", "");
            string role = Microsoft.VisualBasic.Interaction.InputBox("Rôle (Admin/User) :", "Ajouter un utilisateur", "User");

            // Vérifier que tous les champs sont remplis
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(motDePasse) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifier si l'utilisateur existe déjà
            if (Utilisateur.UserExistDeja(email, motDePasse))
            {
                MessageBox.Show("Cet utilisateur existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ajouter l'utilisateur
            int result = Utilisateur.CreateUser(nom, motDePasse, email, role);

            if (result > 0)
            {
                MessageBox.Show("Utilisateur ajouté avec succès !");
                LoadUsers(); // Recharger la liste des utilisateurs
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de l'utilisateur.");
            }
        }

        private void dataGridViewTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadTables()
        {
            try
            {
                DataTable dt = BDD.GetAllTables(); // Récupère toutes les tables depuis la BDD
                dataGridViewTables.DataSource = dt; // Lier les données au DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des tables : " + ex.Message);
            }
        }

        private void btnModifierTable_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                string id = dataGridViewTables.SelectedRows[0].Cells["Id_Table"].Value.ToString();
                string numero = dataGridViewTables.SelectedRows[0].Cells["Numero"].Value.ToString();
                string capacite = dataGridViewTables.SelectedRows[0].Cells["Capapcite"].Value.ToString();
                string statut = dataGridViewTables.SelectedRows[0].Cells["Statut"].Value.ToString();

                numero = Microsoft.VisualBasic.Interaction.InputBox("Modifier le numéro :", "Modifier Table", numero);
                capacite = Microsoft.VisualBasic.Interaction.InputBox("Modifier la capacité :", "Modifier Table", capacite);
                statut = Microsoft.VisualBasic.Interaction.InputBox("Modifier le statut :", "Modifier Table", statut);

                if (string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(capacite) || string.IsNullOrWhiteSpace(statut))
                {
                    MessageBox.Show("Tous les champs doivent être remplis.");
                    return;
                }

                BDD.UpdateTable(id, numero, capacite, statut);
                MessageBox.Show("Table modifiée avec succès !");
                LoadTables(); // Recharge les données
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une table à modifier.");
            }
        }

        private void btnSupprimerTable_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                string id = dataGridViewTables.SelectedRows[0].Cells["Id_Table"].Value.ToString();

                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette table ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    BDD.DeleteTable(id);
                    MessageBox.Show("Table supprimée !");
                    LoadTables(); // Recharge les données
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une table à supprimer.");
            }
        }

        private void btnAjouterTable_Click(object sender, EventArgs e)
        {
            {
                // Boîte de dialogue pour entrer les informations
                string numero = Microsoft.VisualBasic.Interaction.InputBox("Numéro de la table :", "Ajouter une table", "");
                string capacite = Microsoft.VisualBasic.Interaction.InputBox("Capacité de la table :", "Ajouter une table", "");
                string statut = Microsoft.VisualBasic.Interaction.InputBox("Statut (Libre/Occupée) :", "Ajouter une table", "Libre");

                // Vérification des champs
                if (string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(capacite) || string.IsNullOrWhiteSpace(statut))
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ajout dans la BDD
                int result = BDD.CreateTable(numero, capacite, statut);

                if (result > 0)
                {
                    MessageBox.Show("Table ajoutée avec succès !");
                    LoadTables(); // Recharge les données
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de la table.");
                }
            }


        }
    }
}