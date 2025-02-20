namespace le_cantine
{
    partial class Inscription
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
            LblInscrpition = new Label();
            LblEmail = new Label();
            LblMdp = new Label();
            LblNom = new Label();
            LblGrade = new Label();
            TxtbNom = new TextBox();
            TxtbEmail = new TextBox();
            TxtbMdp = new TextBox();
            CbGrade = new ComboBox();
            BtnValider = new Button();
            SuspendLayout();
            // 
            // LblInscrpition
            // 
            LblInscrpition.AutoSize = true;
            LblInscrpition.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblInscrpition.Location = new Point(272, 21);
            LblInscrpition.Name = "LblInscrpition";
            LblInscrpition.Size = new Size(325, 60);
            LblInscrpition.TabIndex = 1;
            LblInscrpition.Text = "Inscription";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(352, 181);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 2;
            LblEmail.Text = "Email";
            LblEmail.Click += LblEmail_Click;
            // 
            // LblMdp
            // 
            LblMdp.AutoSize = true;
            LblMdp.Location = new Point(306, 224);
            LblMdp.Name = "LblMdp";
            LblMdp.Size = new Size(78, 15);
            LblMdp.TabIndex = 3;
            LblMdp.Text = "Mot De Passe";
            // 
            // LblNom
            // 
            LblNom.AutoSize = true;
            LblNom.Location = new Point(355, 136);
            LblNom.Name = "LblNom";
            LblNom.Size = new Size(34, 15);
            LblNom.TabIndex = 4;
            LblNom.Text = "Nom";
            // 
            // LblGrade
            // 
            LblGrade.AutoSize = true;
            LblGrade.Location = new Point(349, 271);
            LblGrade.Name = "LblGrade";
            LblGrade.Size = new Size(38, 15);
            LblGrade.TabIndex = 5;
            LblGrade.Text = "Grade";
            // 
            // TxtbNom
            // 
            TxtbNom.Location = new Point(479, 134);
            TxtbNom.Margin = new Padding(3, 2, 3, 2);
            TxtbNom.Name = "TxtbNom";
            TxtbNom.Size = new Size(110, 23);
            TxtbNom.TabIndex = 6;
            TxtbNom.TextChanged += TxtbNom_TextChanged;
            // 
            // TxtbEmail
            // 
            TxtbEmail.Location = new Point(479, 178);
            TxtbEmail.Margin = new Padding(3, 2, 3, 2);
            TxtbEmail.Name = "TxtbEmail";
            TxtbEmail.Size = new Size(110, 23);
            TxtbEmail.TabIndex = 7;
            // 
            // TxtbMdp
            // 
            TxtbMdp.Location = new Point(479, 222);
            TxtbMdp.Margin = new Padding(3, 2, 3, 2);
            TxtbMdp.Name = "TxtbMdp";
            TxtbMdp.Size = new Size(110, 23);
            TxtbMdp.TabIndex = 8;
            TxtbMdp.TextChanged += TxtbMdp_TextChanged;
            // 
            // CbGrade
            // 
            CbGrade.FormattingEnabled = true;
            CbGrade.Items.AddRange(new object[] { "Admin", "User" });
            CbGrade.Location = new Point(479, 268);
            CbGrade.Margin = new Padding(3, 2, 3, 2);
            CbGrade.Name = "CbGrade";
            CbGrade.Size = new Size(133, 23);
            CbGrade.TabIndex = 9;
            // 
            // BtnValider
            // 
            BtnValider.Location = new Point(365, 340);
            BtnValider.Margin = new Padding(3, 2, 3, 2);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(170, 65);
            BtnValider.TabIndex = 10;
            BtnValider.Text = "Valider";
            BtnValider.UseVisualStyleBackColor = true;
            BtnValider.Click += BtnValider_Click;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 433);
            Controls.Add(BtnValider);
            Controls.Add(CbGrade);
            Controls.Add(TxtbMdp);
            Controls.Add(TxtbEmail);
            Controls.Add(TxtbNom);
            Controls.Add(LblGrade);
            Controls.Add(LblNom);
            Controls.Add(LblMdp);
            Controls.Add(LblEmail);
            Controls.Add(LblInscrpition);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inscription";
            Text = "Inscription";
            Load += Inscription_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblInscrpition;
        private Label LblEmail;
        private Label LblMdp;
        private Label LblNom;
        private Label LblGrade;
        private TextBox TxtbNom;
        private TextBox TxtbEmail;
        private TextBox TxtbMdp;
        private ComboBox CbGrade;
        private Button BtnValider;
    }
}