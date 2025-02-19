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
            menuStrip1 = new MenuStrip();
            utilisateursToolStripMenuItem = new ToolStripMenuItem();
            créerUnUserToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { utilisateursToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // utilisateursToolStripMenuItem
            // 
            utilisateursToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { créerUnUserToolStripMenuItem });
            utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            utilisateursToolStripMenuItem.Size = new Size(96, 24);
            utilisateursToolStripMenuItem.Text = "Utilisateurs";
            // 
            // créerUnUserToolStripMenuItem
            // 
            créerUnUserToolStripMenuItem.Name = "créerUnUserToolStripMenuItem";
            créerUnUserToolStripMenuItem.Size = new Size(224, 26);
            créerUnUserToolStripMenuItem.Text = "Créer un user";
            // 
            // ConnectUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblUtilisateur);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ConnectUser";
            Text = "ConnectUser";
            Load += ConnectUser_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUtilisateur;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem utilisateursToolStripMenuItem;
        private ToolStripMenuItem créerUnUserToolStripMenuItem;
    }
}