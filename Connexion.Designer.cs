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
            LblConnexion.Location = new Point(280, 44);
            LblConnexion.Name = "LblConnexion";
            LblConnexion.Size = new Size(368, 74);
            LblConnexion.TabIndex = 0;
            LblConnexion.Text = "Connexion";
            LblConnexion.Click += label1_Click;
            // 
            // TxtBxEmail
            // 
            TxtBxEmail.Location = new Point(414, 237);
            TxtBxEmail.Margin = new Padding(3, 4, 3, 4);
            TxtBxEmail.Name = "TxtBxEmail";
            TxtBxEmail.Size = new Size(183, 27);
            TxtBxEmail.TabIndex = 1;
            // 
            // TxtBxMotDePasse
            // 
            TxtBxMotDePasse.Location = new Point(414, 293);
            TxtBxMotDePasse.Margin = new Padding(3, 4, 3, 4);
            TxtBxMotDePasse.Name = "TxtBxMotDePasse";
            TxtBxMotDePasse.Size = new Size(183, 27);
            TxtBxMotDePasse.TabIndex = 2;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(327, 241);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(46, 20);
            LblEmail.TabIndex = 3;
            LblEmail.Text = "Email";
            // 
            // LblMotDePasse
            // 
            LblMotDePasse.AutoSize = true;
            LblMotDePasse.Location = new Point(280, 297);
            LblMotDePasse.Name = "LblMotDePasse";
            LblMotDePasse.Size = new Size(96, 20);
            LblMotDePasse.TabIndex = 4;
            LblMotDePasse.Text = "Mot de Passe";
            // 
            // BtnValider
            // 
            BtnValider.Location = new Point(280, 383);
            BtnValider.Margin = new Padding(3, 4, 3, 4);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(176, 72);
            BtnValider.TabIndex = 5;
            BtnValider.Text = "VALIDER";
            BtnValider.UseVisualStyleBackColor = true;
            BtnValider.Click += BtnValider_Click;
            // 
            // BtnInscription
            // 
            BtnInscription.Location = new Point(507, 383);
            BtnInscription.Margin = new Padding(3, 4, 3, 4);
            BtnInscription.Name = "BtnInscription";
            BtnInscription.Size = new Size(176, 72);
            BtnInscription.TabIndex = 6;
            BtnInscription.Text = "INSCRIPTION";
            BtnInscription.UseVisualStyleBackColor = true;
            BtnInscription.Click += BtnInscription_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(BtnInscription);
            Controls.Add(BtnValider);
            Controls.Add(LblMotDePasse);
            Controls.Add(LblEmail);
            Controls.Add(TxtBxMotDePasse);
            Controls.Add(TxtBxEmail);
            Controls.Add(LblConnexion);
            Margin = new Padding(3, 4, 3, 4);
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
