using Command.receiver;

namespace Command.command
{
    public class ArchiveCommand : ICommand
    {
        private readonly FileSystemService fs;
        private readonly string source;
        private readonly string zipName;

        public ArchiveCommand(FileSystemService filesystem, string source, string zipName)
        {
            fs = filesystem;
            this.source = source;
            this.zipName = zipName;
        }

        public void execute()
        {
            fs.archiveFile(source, zipName);
        }
    }
}