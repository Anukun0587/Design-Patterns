namespace Command.receiver
{
    public class FileSystemService
    {
        public void createFile(string path)
        {
            Console.WriteLine($"[FileSystem] Created {path}");
        }

        public void deleteFile(string path)
        {
            Console.WriteLine($"[FileSystem] Deleted: {path}");
        }

        public void copyFile(string source, string dest)
        {
            Console.WriteLine($"[FileSystem] Copied: {source} to {dest}");
        }

        public void archiveFile(string source, string zipName)
        {
            Console.WriteLine($"[FileSystem] Archiving: {source} -> {zipName}.zip");
        }
    }
}