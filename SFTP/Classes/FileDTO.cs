namespace SFTP;

public class FileDTO
{
    public string FileName { get; set; }
    public DateTime LastWriteTime { get; set; }
    public long FileSize { get; set; }
}
