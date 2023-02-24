using Renci.SshNet;

namespace SFTP
{
    public partial class Form1 : Form
    {
        private string? _localFolderValue;
        private string? _localFolder
        {
            set
            {
                if (value != null)
                {
                    this.btnDownload.Enabled = true;
                    this.btnUpload.Enabled = true;
                    this.btnListRemote.Enabled = true;
                    this.btnDeleteLocal.Enabled = true;
                }
                else
                {
                    this.btnDownload.Enabled = false;
                    this.btnUpload.Enabled = false;
                    this.btnListRemote.Enabled = false;
                    this.btnDeleteLocal.Enabled = false;
                }
                _localFolderValue = value;
            }
            get
            {
                return _localFolderValue;
            }
        }
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
                this.btnDeleteRemote.Enabled = true;
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
                _localFolder = txtLocalFolderName.Text;
            }
            else
            {
                _localFolder = null;
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
            foreach (DataGridViewRow selectedFile in selectedLocalFiles)
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

        private void btnDeleteLocal_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection? selectedLocalFiles = this.dgLocalFolder.SelectedRows;
            if (selectedLocalFiles == null || selectedLocalFiles.Count == 0)
            {
                this.lblMessage.Text = "Please select files in the local folder";
                return;
            }

            List<string> filesToDelete = new List<string>();
            foreach (DataGridViewRow selectedFile in selectedLocalFiles)
            {
                filesToDelete.Add(Path.Combine(this.txtLocalFolderName.Text, selectedFile.Cells[0].Value.ToString()));
            }

            var result = SFTP.Classes.SFTP.DeleteLocal(filesToDelete, _localFolder);
            this.lblMessage.Text = result.Item1;
            this.dgLocalFolder.DataSource = result.Item2;
        }

        private void btnDeleteRemote_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection? selectedRemoteFiles = this.dgRemoteFolder.SelectedRows;
            if (selectedRemoteFiles == null || selectedRemoteFiles.Count == 0)
            {
                this.lblMessage.Text = "Please select files in the remote folder";
                return;
            }
            List<string> filesToDelete = new List<string>();
            foreach (DataGridViewRow selectedFile in selectedRemoteFiles)
            {
                filesToDelete.Add(selectedFile.Cells[0].Value.ToString());
            }

            try
            {
                using (SFTP.Classes.SFTP sftp = new SFTP.Classes.SFTP(this.txtServerName.Text, this.txtUsername.Text, this.txtPassword.Text, this.txtFolderName.Text))
                {
                    var result = sftp.Delete(filesToDelete);
                    this.lblMessage.Text = result.Item1;
                    this.dgRemoteFolder.DataSource = result.Item2;
                }
            }
            catch (Exception ex)
            {
                this.lblMessage.Text = ex.Message;
            }

        }
    }
}