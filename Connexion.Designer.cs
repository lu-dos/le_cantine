namespace le_cantine
{
    partial class Connexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblConnexion = new Label();
            TxtBxEmail = new TextBox();
            TxtBxMotDePasse = new TextBox();
            LblEmail = new Label();
            LblMotDePasse = new Label();
            BtnValider = new Button();
            BtnInscription = new Button();
            SuspendLayout();
            // 
            // LblConnexion
            // 
            LblConnexion.AutoSize = true;
            LblConnexion.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblConnexion.Location = new Point(245, 33);
            LblConnexion.Name = "LblConnexion";
            LblConnexion.Size = new Size(303, 60);
            LblConnexion.TabIndex = 0;
            LblConnexion.Text = "Connexion";
            LblConnexion.Click += label1_Click;
            // 
            // TxtBxEmail
            // 
            TxtBxEmail.Location = new Point(362, 178);
            TxtBxEmail.Name = "TxtBxEmail";
            TxtBxEmail.Size = new Size(161, 23);
            TxtBxEmail.TabIndex = 1;
            // 
            // TxtBxMotDePasse
            // 
            TxtBxMotDePasse.Location = new Point(362, 220);
            TxtBxMotDePasse.Name = "TxtBxMotDePasse";
            TxtBxMotDePasse.Size = new Size(161, 23);
            TxtBxMotDePasse.TabIndex = 2;
            TxtBxMotDePasse.TextChanged += TxtBxMotDePasse_TextChanged;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(286, 181);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 3;
            LblEmail.Text = "Email";
            // 
            // LblMotDePasse
            // 
            LblMotDePasse.AutoSize = true;
            LblMotDePasse.Location = new Point(245, 223);
            LblMotDePasse.Name = "LblMotDePasse";
            LblMotDePasse.Size = new Size(77, 15);
            LblMotDePasse.TabIndex = 4;
            LblMotDePasse.Text = "Mot de Passe";
            // 
            // BtnValider
            // 
            BtnValider.Location = new Point(245, 287);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(154, 54);
            BtnValider.TabIndex = 5;
            BtnValider.Text = "VALIDER";
            BtnValider.UseVisualStyleBackColor = true;
            BtnValider.Click += BtnValider_Click;
            // 
            // BtnInscription
            // 
            BtnInscription.Location = new Point(444, 287);
            BtnInscription.Name = "BtnInscription";
            BtnInscription.Size = new Size(154, 54);
            BtnInscription.TabIndex = 6;
            BtnInscription.Text = "INSCRIPTION";
            BtnInscription.UseVisualStyleBackColor = true;
            BtnInscription.Click += BtnInscription_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnInscription);
            Controls.Add(BtnValider);
            Controls.Add(LblMotDePasse);
            Controls.Add(LblEmail);
            Controls.Add(TxtBxMotDePasse);
            Controls.Add(TxtBxEmail);
            Controls.Add(LblConnexion);
            Name = "Connexion";
            Text = "Connexion";
            Load += Connexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblConnexion;
        private TextBox TxtBxEmail;
        private TextBox TxtBxMotDePasse;
        private Label LblEmail;
        private Label LblMotDePasse;
        private Button BtnValider;
        private Button BtnInscription;
    }
}
