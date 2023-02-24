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
            label4 = new Label();
            txtFolderName = new TextBox();
            dgLocalFolder = new DataGridView();
            dgRemoteFolder = new DataGridView();
            btnUpload = new Button();
            btnDownload = new Button();
            btnListRemote = new Button();
            btnExploreLocalFolder = new Button();
            lblMessage = new Label();
            txtLocalFolderName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgLocalFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgRemoteFolder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 0;
            label1.Text = "Server Name";
            label1.Click += label1_Click;
            // 
            // txtServerName
            // 
            txtServerName.Location = new Point(116, 25);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(388, 26);
            txtServerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 72);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(116, 69);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(190, 26);
            txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 115);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(116, 112);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(190, 26);
            txtPassword.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 156);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 6;
            label4.Text = "FolderName";
            // 
            // txtFolderName
            // 
            txtFolderName.Location = new Point(116, 153);
            txtFolderName.Name = "txtFolderName";
            txtFolderName.Size = new Size(190, 26);
            txtFolderName.TabIndex = 7;
            // 
            // dgLocalFolder
            // 
            dgLocalFolder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLocalFolder.Location = new Point(30, 203);
            dgLocalFolder.Name = "dgLocalFolder";
            dgLocalFolder.RowTemplate.Height = 28;
            dgLocalFolder.Size = new Size(485, 446);
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
            btnListRemote.Location = new Point(577, 157);
            btnListRemote.Name = "btnListRemote";
            btnListRemote.Size = new Size(75, 40);
            btnListRemote.TabIndex = 12;
            btnListRemote.Text = "List";
            btnListRemote.UseVisualStyleBackColor = true;
            btnListRemote.Click += btnListRemote_Click;
            // 
            // btnExploreLocalFolder
            // 
            btnExploreLocalFolder.Location = new Point(466, 157);
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
            lblMessage.Location = new Point(577, 32);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(46, 19);
            lblMessage.TabIndex = 14;
            lblMessage.Text = "Ready";
            // 
            // txtLocalFolderName
            // 
            txtLocalFolderName.Enabled = false;
            txtLocalFolderName.Location = new Point(30, 658);
            txtLocalFolderName.Name = "txtLocalFolderName";
            txtLocalFolderName.Size = new Size(485, 26);
            txtLocalFolderName.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 696);
            Controls.Add(txtLocalFolderName);
            Controls.Add(lblMessage);
            Controls.Add(btnExploreLocalFolder);
            Controls.Add(btnListRemote);
            Controls.Add(btnDownload);
            Controls.Add(btnUpload);
            Controls.Add(dgRemoteFolder);
            Controls.Add(dgLocalFolder);
            Controls.Add(txtFolderName);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(txtServerName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "SFTP";
            ((System.ComponentModel.ISupportInitialize)dgLocalFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgRemoteFolder).EndInit();
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
        private Label label4;
        private TextBox txtFolderName;
        private DataGridView dgLocalFolder;
        private DataGridView dgRemoteFolder;
        private Button btnUpload;
        private Button btnDownload;
        private Button btnListRemote;
        private Button btnExploreLocalFolder;
        private Label lblMessage;
        private TextBox txtLocalFolderName;
    }
}