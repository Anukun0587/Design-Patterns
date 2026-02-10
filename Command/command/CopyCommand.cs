using Command.receiver;

namespace Command.command
{
    public class CopyCommand : ICommand
    {
        private readonly FileSystemService fs;
        private readonly string source;
        private readonly string dest;

        public CopyCommand(FileSystemService filesystem, string source, string dest)
        {
            fs = filesystem;
            this.source = source;
            this.dest = dest;
        }

        public void execute()
        {
            fs.copyFile(source, dest);
        }
    }
}