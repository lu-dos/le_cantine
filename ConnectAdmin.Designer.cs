namespace le_cantine
{
    partial class ConnectAdmin
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
            tabControl1 = new TabControl();
            TabModifUser = new TabPage();
            dataGridViewUsers = new DataGridView();
            TabReserv = new TabPage();
            TabCommandes = new TabPage();
            tabControl1.SuspendLayout();
            TabModifUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabModifUser);
            tabControl1.Controls.Add(TabReserv);
            tabControl1.Controls.Add(TabCommandes);
            tabControl1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1303, 715);
            tabControl1.TabIndex = 0;
            // 
            // TabModifUser
            // 
            TabModifUser.Controls.Add(dataGridViewUsers);
            TabModifUser.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabModifUser.Location = new Point(4, 38);
            TabModifUser.Name = "TabModifUser";
            TabModifUser.Padding = new Padding(3);
            TabModifUser.Size = new Size(1295, 673);
            TabModifUser.TabIndex = 0;
            TabModifUser.Text = "Gestion des utilisateurs";
            TabModifUser.UseVisualStyleBackColor = true;
            TabModifUser.Click += TabModifUser_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToOrderColumns = true;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(8, 6);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(931, 659);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TabReserv
            // 
            TabReserv.Location = new Point(4, 38);
            TabReserv.Name = "TabReserv";
            TabReserv.Padding = new Padding(3);
            TabReserv.Size = new Size(1295, 673);
            TabReserv.TabIndex = 1;
            TabReserv.Text = "Gestion des Tables";
            TabReserv.UseVisualStyleBackColor = true;
            TabReserv.Click += tabPage2_Click;
            // 
            // TabCommandes
            // 
            TabCommandes.Location = new Point(4, 38);
            TabCommandes.Name = "TabCommandes";
            TabCommandes.Padding = new Padding(3);
            TabCommandes.Size = new Size(1295, 673);
            TabCommandes.TabIndex = 2;
            TabCommandes.Text = "Commandes";
            TabCommandes.UseVisualStyleBackColor = true;
            // 
            // ConnectAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 715);
            Controls.Add(tabControl1);
            Name = "ConnectAdmin";
            Text = "ConnectAdmin";
            Load += ConnectAdmin_Load;
            tabControl1.ResumeLayout(false);
            TabModifUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabModifUser;
        private TabPage TabReserv;
        private TabPage TabCommandes;
        private DataGridView dataGridViewUsers;
    }
}