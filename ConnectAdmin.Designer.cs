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
            btnAjouterUser = new Button();
            btnSupprimerUser = new Button();
            btnModifierUser = new Button();
            dataGridViewUsers = new DataGridView();
            TabReserv = new TabPage();
            btnAjouterTable = new Button();
            btnSupprimerTable = new Button();
            btnModifierTable = new Button();
            dataGridViewTables = new DataGridView();
            TabCommandes = new TabPage();
            btnModifierCommandes = new Button();
            dataGridCommandes = new DataGridView();
            BtnAjtCommande = new Button();
            tabControl1.SuspendLayout();
            TabModifUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            TabReserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).BeginInit();
            TabCommandes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCommandes).BeginInit();
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
            TabModifUser.Controls.Add(btnAjouterUser);
            TabModifUser.Controls.Add(btnSupprimerUser);
            TabModifUser.Controls.Add(btnModifierUser);
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
            // btnAjouterUser
            // 
            btnAjouterUser.BackColor = Color.GreenYellow;
            btnAjouterUser.Location = new Point(1008, 259);
            btnAjouterUser.Name = "btnAjouterUser";
            btnAjouterUser.Size = new Size(147, 83);
            btnAjouterUser.TabIndex = 3;
            btnAjouterUser.Text = "Ajouter";
            btnAjouterUser.UseVisualStyleBackColor = false;
            btnAjouterUser.Click += btnAjouterUser_Click;
            // 
            // btnSupprimerUser
            // 
            btnSupprimerUser.BackColor = Color.Red;
            btnSupprimerUser.Location = new Point(1008, 153);
            btnSupprimerUser.Name = "btnSupprimerUser";
            btnSupprimerUser.Size = new Size(147, 83);
            btnSupprimerUser.TabIndex = 2;
            btnSupprimerUser.Text = "Supprimer";
            btnSupprimerUser.UseVisualStyleBackColor = false;
            btnSupprimerUser.Click += btnSupprimerUser_Click;
            // 
            // btnModifierUser
            // 
            btnModifierUser.BackColor = Color.SandyBrown;
            btnModifierUser.Location = new Point(1008, 47);
            btnModifierUser.Name = "btnModifierUser";
            btnModifierUser.Size = new Size(147, 83);
            btnModifierUser.TabIndex = 1;
            btnModifierUser.Text = "Modifier";
            btnModifierUser.UseVisualStyleBackColor = false;
            btnModifierUser.Click += btnModifierUser_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToOrderColumns = true;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(8, 5);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(931, 659);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TabReserv
            // 
            TabReserv.Controls.Add(btnAjouterTable);
            TabReserv.Controls.Add(btnSupprimerTable);
            TabReserv.Controls.Add(btnModifierTable);
            TabReserv.Controls.Add(dataGridViewTables);
            TabReserv.Location = new Point(4, 38);
            TabReserv.Name = "TabReserv";
            TabReserv.Padding = new Padding(3);
            TabReserv.Size = new Size(1295, 673);
            TabReserv.TabIndex = 1;
            TabReserv.Text = "Gestion des Tables";
            TabReserv.UseVisualStyleBackColor = true;
            TabReserv.Click += tabPage2_Click;
            // 
            // btnAjouterTable
            // 
            btnAjouterTable.BackColor = Color.GreenYellow;
            btnAjouterTable.Font = new Font("Arial Narrow", 13.8F);
            btnAjouterTable.Location = new Point(1045, 312);
            btnAjouterTable.Name = "btnAjouterTable";
            btnAjouterTable.Size = new Size(155, 87);
            btnAjouterTable.TabIndex = 3;
            btnAjouterTable.Text = "Ajouter";
            btnAjouterTable.UseVisualStyleBackColor = false;
            btnAjouterTable.Click += btnAjouterTable_Click;
            // 
            // btnSupprimerTable
            // 
            btnSupprimerTable.BackColor = Color.Red;
            btnSupprimerTable.Font = new Font("Arial Narrow", 13.8F);
            btnSupprimerTable.Location = new Point(1045, 171);
            btnSupprimerTable.Name = "btnSupprimerTable";
            btnSupprimerTable.Size = new Size(155, 87);
            btnSupprimerTable.TabIndex = 2;
            btnSupprimerTable.Text = "Supprimer";
            btnSupprimerTable.UseVisualStyleBackColor = false;
            btnSupprimerTable.Click += btnSupprimerTable_Click;
            // 
            // btnModifierTable
            // 
            btnModifierTable.BackColor = Color.SandyBrown;
            btnModifierTable.Font = new Font("Arial Narrow", 13.8F);
            btnModifierTable.Location = new Point(1045, 31);
            btnModifierTable.Name = "btnModifierTable";
            btnModifierTable.Size = new Size(155, 87);
            btnModifierTable.TabIndex = 1;
            btnModifierTable.Text = "Modifier";
            btnModifierTable.UseVisualStyleBackColor = false;
            btnModifierTable.Click += btnModifierTable_Click;
            // 
            // dataGridViewTables
            // 
            dataGridViewTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTables.Location = new Point(6, 5);
            dataGridViewTables.Name = "dataGridViewTables";
            dataGridViewTables.RowHeadersWidth = 51;
            dataGridViewTables.Size = new Size(942, 627);
            dataGridViewTables.TabIndex = 0;
            dataGridViewTables.CellContentClick += dataGridViewTables_CellContentClick;
            // 
            // TabCommandes
            // 
            TabCommandes.Controls.Add(BtnAjtCommande);
            TabCommandes.Controls.Add(btnModifierCommandes);
            TabCommandes.Controls.Add(dataGridCommandes);
            TabCommandes.Location = new Point(4, 38);
            TabCommandes.Name = "TabCommandes";
            TabCommandes.Padding = new Padding(3);
            TabCommandes.Size = new Size(1295, 673);
            TabCommandes.TabIndex = 2;
            TabCommandes.Text = "Commandes";
            TabCommandes.UseVisualStyleBackColor = true;
            // 
            // btnModifierCommandes
            // 
            btnModifierCommandes.BackColor = Color.Orange;
            btnModifierCommandes.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifierCommandes.Location = new Point(1048, 67);
            btnModifierCommandes.Name = "btnModifierCommandes";
            btnModifierCommandes.Size = new Size(130, 68);
            btnModifierCommandes.TabIndex = 1;
            btnModifierCommandes.Text = "Modifier";
            btnModifierCommandes.UseVisualStyleBackColor = false;
            btnModifierCommandes.Click += btnModifierCommandes_Click;
            // 
            // dataGridCommandes
            // 
            dataGridCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCommandes.Location = new Point(6, 5);
            dataGridCommandes.Name = "dataGridCommandes";
            dataGridCommandes.RowHeadersWidth = 51;
            dataGridCommandes.Size = new Size(941, 659);
            dataGridCommandes.TabIndex = 0;
            dataGridCommandes.CellContentClick += dataGridCommandes_CellContentClick;
            // 
            // BtnAjtCommande
            // 
            BtnAjtCommande.BackColor = Color.GreenYellow;
            BtnAjtCommande.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAjtCommande.Location = new Point(1048, 174);
            BtnAjtCommande.Name = "BtnAjtCommande";
            BtnAjtCommande.Size = new Size(130, 68);
            BtnAjtCommande.TabIndex = 2;
            BtnAjtCommande.Text = "Ajouter";
            BtnAjtCommande.UseVisualStyleBackColor = false;
            BtnAjtCommande.Click += BtnAjtCommande_Click;
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
            TabReserv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).EndInit();
            TabCommandes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCommandes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabModifUser;
        private TabPage TabReserv;
        private TabPage TabCommandes;
        private DataGridView dataGridViewUsers;
        private Button btnModifierUser;
        private Button btnSupprimerUser;
        private Button btnAjouterUser;
        private DataGridView dataGridViewTables;
        private Button btnModifierTable;
        private Button btnSupprimerTable;
        private Button btnAjouterTable;
        private DataGridView dataGridCommandes;
        private Button btnModifierCommandes;
        private Button BtnAjtCommande;
    }
}