using Renci.SshNet;

namespace SFTP.Classes;

public class SFTP : IDisposable
{
    private SftpClient _sftpClient;
    private readonly string _folderName;

    public SFTP(string serverName, string username, string password, string folderName)
    {
        _sftpClient = new SftpClient(serverName, username, password);
        
        _sftpClient.Connect();

        if (!string.IsNullOrEmpty(folderName))
            _sftpClient.ChangeDirectory(folderName);

        _sftpClient.BufferSize = 4 * 1024;
        this._folderName = folderName;
    }

    public IEnumerable<FileDTO> ListFiles()
    {
        IEnumerable<Renci.SshNet.Sftp.SftpFile> filesOnServer = _sftpClient.ListDirectory(this._folderName, null);

        IEnumerable<FileDTO> files = from f in filesOnServer
                                     select new FileDTO() { FileName = f.Name, LastWriteTime = f.LastWriteTime, FileSize = f.Length };

        return files;
    }

    public Tuple<string,List<FileDTO>?> Upload(List<string> files)
    {
        foreach (string filename in files)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                _sftpClient.UploadFile(fs, new FileInfo(filename).Name);
            }
        }
       return new Tuple<string,List<FileDTO>?>($"{files.Count} have been uploaded", ListFiles()?.ToList());
    }

    public string DownLoad(List<string> files, string localfolderName)
    {
        foreach (string filename in files)
        {
            string fileDL = Path.Combine(localfolderName, filename);
            if (File.Exists(fileDL))
                File.Delete(fileDL);

            using (FileStream fs = new FileStream(fileDL, FileMode.Create))
                _sftpClient.DownloadFile(filename, fs);
        }
        return $"{files.Count} have been downloaded";
    }

    public void Dispose()
    {
        _sftpClient?.Dispose();
    }
}
