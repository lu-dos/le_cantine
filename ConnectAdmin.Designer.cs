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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            TabModifUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            TabReserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).BeginInit();
            TabCommandes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnAjouterUser.Location = new Point(1008, 258);
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
            dataGridViewUsers.Location = new Point(8, 6);
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
            btnSupprimerTable.Location = new Point(1045, 170);
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
            dataGridViewTables.Location = new Point(6, 6);
            dataGridViewTables.Name = "dataGridViewTables";
            dataGridViewTables.RowHeadersWidth = 51;
            dataGridViewTables.Size = new Size(942, 627);
            dataGridViewTables.TabIndex = 0;
            dataGridViewTables.CellContentClick += dataGridViewTables_CellContentClick;
            // 
            // TabCommandes
            // 
            TabCommandes.Controls.Add(button1);
            TabCommandes.Controls.Add(dataGridView1);
            TabCommandes.Location = new Point(4, 38);
            TabCommandes.Name = "TabCommandes";
            TabCommandes.Padding = new Padding(3);
            TabCommandes.Size = new Size(1295, 673);
            TabCommandes.TabIndex = 2;
            TabCommandes.Text = "Commandes";
            TabCommandes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1074, 72);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(941, 659);
            dataGridView1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button button1;
    }
}