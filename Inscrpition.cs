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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
            BDD.GetConnection();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {

            // Vérifier si aucun des champs n'est vide
            if (Utilisateur.ValidateTextBoxes(TxtbNom, TxtbMdp, TxtbEmail) && Utilisateur.ValidateComboBoxes(CbGrade))
            {
                // Vérifier si le nom d'utilisateur ou l'email existe déjà
                if (Utilisateur.UserExistDeja(TxtbEmail.Text, TxtbMdp.Text))
                {
                    // Un message s'affiche si le nom d'utilisateur ou l'email existe déjà
                    MessageBox.Show("Le nom d'utilisateur ou l'email existe déjà. Veuillez en choisir un autre.");
                }
                else
                {
                    // Procéder avec la création de l'utilisateur si tous les champs sont remplis et si l'utilisateur n'existe pas
                    int result = Utilisateur.CreateUser(TxtbNom.Text, TxtbMdp.Text, TxtbEmail.Text, CbGrade.Text);

                    // Vérifier le résultat de la création de l'utilisateur
                    if (result > 0)
                    {
                        // Un message s'affiche si le compte a été créé avec succès
                        MessageBox.Show("Compte créé avec succès");
                    }
                    else
                    {
                        // Un message s'affiche en cas d'erreur lors de la création du compte
                        MessageBox.Show("Erreur lors de la création du compte");
                    }
                }
            }

        }

        private void TxtbNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblEmail_Click(object sender, EventArgs e)
        {

        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            TxtbMdp.PasswordChar = '•';  // Utilise des points (•) pour masquer le mot de passe
        }

        private void TxtbMdp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
