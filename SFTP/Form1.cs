using Renci.SshNet;

namespace SFTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.txtServerName.Text = "";
            this.txtUsername.Text = "";
            this.txtFolderName.Text = "";
#if DEBUG
            this.txtPassword.Text = "";
#endif
        }

        private void btnListRemote_Click(object sender, EventArgs e)
        {
            using (SFTP.Classes.SFTP sftp = new SFTP.Classes.SFTP(this.txtServerName.Text, this.txtUsername.Text, this.txtPassword.Text, this.txtFolderName.Text))
            {
                IEnumerable<FileDTO> files = sftp.ListFiles();
                this.dgRemoteFolder.DataSource = files?.ToList();
                this.dgRemoteFolder.Columns[0].Width = 250;
                this.dgRemoteFolder.Columns[1].Width = 150;
                this.lblMessage.Text = $"{files?.Count()} files shown";
            }
        }

        private void btnExploreLocalFolder_Click(object sender, EventArgs e)
        {
            PopUpFolderSearch.Popup(txtLocalFolderName);

            this.lblMessage.Text = $"Local folder: {this.txtLocalFolderName.Text}";

            if (Directory.Exists(txtLocalFolderName.Text))
            {
                FileInfo[] filesLocal = new DirectoryInfo(txtLocalFolderName.Text).GetFiles();
                IEnumerable<FileDTO> files = from f in filesLocal
                                             select new FileDTO() { FileName = f.Name, LastWriteTime = f.LastWriteTime, FileSize = f.Length };
                this.dgLocalFolder.DataSource = files?.ToList();
                this.dgLocalFolder.Columns[0].Width = 250;
                this.dgLocalFolder.Columns[1].Width = 150;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection? selectedLocalFiles = this.dgLocalFolder.SelectedRows;
            if (selectedLocalFiles == null || selectedLocalFiles.Count == 0)
            {
                this.lblMessage.Text = "Please select files in the local folder";
                return;
            }

            List<string> filesToUpload = new List<string>();
            foreach ( DataGridViewRow selectedFile in selectedLocalFiles )
            {
                filesToUpload.Add(Path.Combine(this.txtLocalFolderName.Text, selectedFile.Cells[0].Value.ToString()));
            }

            try
            {
                using (SFTP.Classes.SFTP sftp = new SFTP.Classes.SFTP(this.txtServerName.Text, this.txtUsername.Text, this.txtPassword.Text, this.txtFolderName.Text))
                {
                    Tuple<string, List<FileDTO>?> result = sftp.Upload(filesToUpload);
                    this.lblMessage.Text = result.Item1;
                    this.dgRemoteFolder.DataSource = result.Item2;
                }
            }
            catch (Exception ex)
            {
                this.lblMessage.Text = ex.Message;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection? selectedRemoteFiles = this.dgRemoteFolder.SelectedRows;
            if (selectedRemoteFiles == null || selectedRemoteFiles.Count == 0)
            {
                this.lblMessage.Text = "Please select files in the remote folder";
                return;
            }
            List<string> filesToDownload = new List<string>();
            foreach (DataGridViewRow selectedFile in selectedRemoteFiles)
            {
                filesToDownload.Add(selectedFile.Cells[0].Value.ToString());
            }

            try
            {
                using (SFTP.Classes.SFTP sftp = new SFTP.Classes.SFTP(this.txtServerName.Text, this.txtUsername.Text, this.txtPassword.Text, this.txtFolderName.Text))
                {
                    this.lblMessage.Text = sftp.DownLoad(filesToDownload, this.txtLocalFolderName.Text);
                }
            }
            catch (Exception ex)
            {
                this.lblMessage.Text = ex.Message;
            }
        }
    }
}