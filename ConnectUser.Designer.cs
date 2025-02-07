namespace le_cantine
{
    partial class ConnectUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblUtilisateur = new Label();
            SuspendLayout();
            // 
            // LblUtilisateur
            // 
            LblUtilisateur.AutoSize = true;
            LblUtilisateur.Location = new Point(454, 76);
            LblUtilisateur.Name = "LblUtilisateur";
            LblUtilisateur.Size = new Size(76, 20);
            LblUtilisateur.TabIndex = 0;
            LblUtilisateur.Text = "Utilisateur";
            // 
            // ConnectUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblUtilisateur);
            Name = "ConnectUser";
            Text = "ConnectUser";
            Load += ConnectUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUtilisateur;
    }
}