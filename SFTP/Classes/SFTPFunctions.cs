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

    public Tuple<string, List<FileDTO>?> Delete(List<string> filenames)
    {
        foreach (string filename in filenames)
        {
           
            _sftpClient.DeleteFile(filename);
            
        }
        return new Tuple<string, List<FileDTO>?>($"{filenames.Count} files from {_folderName} have been deleted", ListFiles()?.ToList());
    }

    public string DeleteFolder(string folderName)
    {

        _sftpClient.DeleteFile(folderName);

        return $"folder {folderName} have been deleted";
    }

    public static Tuple<string, List<FileDTO>?> DeleteLocal(List<string> filenames, string localFolderName)
    {
        foreach (string filename in filenames)
        {

            File.Delete(filename);

        }

        FileInfo[] files = new DirectoryInfo(localFolderName).GetFiles();
        IEnumerable<FileDTO> fileDTOs = from f in files select new FileDTO() {  FileName = f.Name, FileSize = f.Length, LastWriteTime = f.LastWriteTime }; 
        return new Tuple<string, List<FileDTO>?>($"{filenames.Count} have been deleted", fileDTOs?.ToList());
    }

    public void Dispose()
    {
        _sftpClient?.Dispose();
    }
}
