namespace le_cantine
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            BDD.GetConnexion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnInscription_Click(object sender, EventArgs e)
        {
            Inscription form2 = new Inscription();  // Cr�e une instance de Form2
            form2.Show();                           // Affiche Form2

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            string email = TxtBxEmail.Text;
            string motDePasse = TxtBxMotDePasse.Text;
            string role = BDD.GetUserRole(email, motDePasse);

            if (role != null)
            {
                MessageBox.Show("Bienvenue");

                if (role == "Admin")
                {
                    ConnectAdmin formAdmin = new ConnectAdmin();
                    formAdmin.Show();
                }
                else if (role == "User")
                {
                    ConnectUser formUser = new ConnectUser();
                    formUser.Show();
                }
                else
                {
                    MessageBox.Show("R�le inconnu, acc�s refus� !");
                }

                this.Hide(); // Cache la fen�tre de connexion apr�s l'ouverture
            }
            else
            {
                MessageBox.Show("Compte inconnu");
            }

        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
