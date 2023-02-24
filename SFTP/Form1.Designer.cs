namespace SFTP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtServerName = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            txtFolderName = new TextBox();
            dgLocalFolder = new DataGridView();
            dgRemoteFolder = new DataGridView();
            btnUpload = new Button();
            btnDownload = new Button();
            btnListRemote = new Button();
            btnExploreLocalFolder = new Button();
            lblMessage = new Label();
            txtLocalFolderName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            serverListToolStripMenuItem = new ToolStripMenuItem();
            btnDeleteLocal = new Button();
            btnDeleteRemote = new Button();
            ((System.ComponentModel.ISupportInitialize)dgLocalFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgRemoteFolder).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(577, 47);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 0;
            label1.Text = "Server Name";
            label1.Click += label1_Click;
            // 
            // txtServerName
            // 
            txtServerName.Location = new Point(670, 44);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(390, 26);
            txtServerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(593, 91);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(670, 88);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(192, 26);
            txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(597, 134);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(670, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 26);
            txtPassword.TabIndex = 5;
            // 
            // txtFolderName
            // 
            txtFolderName.Location = new Point(670, 172);
            txtFolderName.Name = "txtFolderName";
            txtFolderName.Size = new Size(311, 26);
            txtFolderName.TabIndex = 7;
            // 
            // dgLocalFolder
            // 
            dgLocalFolder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLocalFolder.Location = new Point(30, 102);
            dgLocalFolder.Name = "dgLocalFolder";
            dgLocalFolder.RowTemplate.Height = 28;
            dgLocalFolder.Size = new Size(485, 547);
            dgLocalFolder.TabIndex = 8;
            // 
            // dgRemoteFolder
            // 
            dgRemoteFolder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRemoteFolder.Location = new Point(577, 203);
            dgRemoteFolder.Name = "dgRemoteFolder";
            dgRemoteFolder.RowTemplate.Height = 28;
            dgRemoteFolder.Size = new Size(485, 446);
            dgRemoteFolder.TabIndex = 9;
            // 
            // btnUpload
            // 
            btnUpload.Enabled = false;
            btnUpload.Location = new Point(521, 370);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(50, 46);
            btnUpload.TabIndex = 10;
            btnUpload.Text = ">";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnDownload
            // 
            btnDownload.Enabled = false;
            btnDownload.Location = new Point(521, 422);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(50, 46);
            btnDownload.TabIndex = 11;
            btnDownload.Text = "<";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnListRemote
            // 
            btnListRemote.Enabled = false;
            btnListRemote.Location = new Point(987, 158);
            btnListRemote.Name = "btnListRemote";
            btnListRemote.Size = new Size(75, 40);
            btnListRemote.TabIndex = 12;
            btnListRemote.Text = "List";
            btnListRemote.UseVisualStyleBackColor = true;
            btnListRemote.Click += btnListRemote_Click;
            // 
            // btnExploreLocalFolder
            // 
            btnExploreLocalFolder.Location = new Point(466, 57);
            btnExploreLocalFolder.Name = "btnExploreLocalFolder";
            btnExploreLocalFolder.Size = new Size(49, 40);
            btnExploreLocalFolder.TabIndex = 13;
            btnExploreLocalFolder.Text = "...";
            btnExploreLocalFolder.UseVisualStyleBackColor = true;
            btnExploreLocalFolder.Click += btnExploreLocalFolder_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(30, 36);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(46, 19);
            lblMessage.TabIndex = 14;
            lblMessage.Text = "Ready";
            // 
            // txtLocalFolderName
            // 
            txtLocalFolderName.Enabled = false;
            txtLocalFolderName.Location = new Point(118, 71);
            txtLocalFolderName.Name = "txtLocalFolderName";
            txtLocalFolderName.Size = new Size(342, 26);
            txtLocalFolderName.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 74);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 16;
            label5.Text = "Local Folder";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(569, 178);
            label6.Name = "label6";
            label6.Size = new Size(95, 19);
            label6.TabIndex = 17;
            label6.Text = "Remote folder";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { serverListToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1101, 27);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // serverListToolStripMenuItem
            // 
            serverListToolStripMenuItem.Name = "serverListToolStripMenuItem";
            serverListToolStripMenuItem.Size = new Size(84, 23);
            serverListToolStripMenuItem.Text = "Server List";
            // 
            // btnDeleteLocal
            // 
            btnDeleteLocal.Enabled = false;
            btnDeleteLocal.Location = new Point(440, 655);
            btnDeleteLocal.Name = "btnDeleteLocal";
            btnDeleteLocal.Size = new Size(75, 37);
            btnDeleteLocal.TabIndex = 19;
            btnDeleteLocal.Text = "Delete";
            btnDeleteLocal.UseVisualStyleBackColor = true;
            btnDeleteLocal.Click += btnDeleteLocal_Click;
            // 
            // btnDeleteRemote
            // 
            btnDeleteRemote.Enabled = false;
            btnDeleteRemote.Location = new Point(987, 655);
            btnDeleteRemote.Name = "btnDeleteRemote";
            btnDeleteRemote.Size = new Size(75, 37);
            btnDeleteRemote.TabIndex = 20;
            btnDeleteRemote.Text = "Delete";
            btnDeleteRemote.UseVisualStyleBackColor = true;
            btnDeleteRemote.Click += btnDeleteRemote_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 704);
            Controls.Add(btnDeleteRemote);
            Controls.Add(btnDeleteLocal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLocalFolderName);
            Controls.Add(lblMessage);
            Controls.Add(btnExploreLocalFolder);
            Controls.Add(btnListRemote);
            Controls.Add(btnDownload);
            Controls.Add(btnUpload);
            Controls.Add(dgRemoteFolder);
            Controls.Add(dgLocalFolder);
            Controls.Add(txtFolderName);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(txtServerName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "SFTP";
            ((System.ComponentModel.ISupportInitialize)dgLocalFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgRemoteFolder).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtServerName;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtFolderName;
        private DataGridView dgLocalFolder;
        private DataGridView dgRemoteFolder;
        private Button btnUpload;
        private Button btnDownload;
        private Button btnListRemote;
        private Button btnExploreLocalFolder;
        private Label lblMessage;
        private TextBox txtLocalFolderName;
        private Label label5;
        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem serverListToolStripMenuItem;
        private Button btnDeleteLocal;
        private Button btnDeleteRemote;
    }
}