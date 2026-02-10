using Command.receiver;

namespace Command.command
{
    public class CreateCommand : ICommand
    {
        private FileSystemService fs;
        private string path;

        public CreateCommand(FileSystemService filesystem, string filePath)
        {
            fs = filesystem;
            path = filePath;
        }

        public void execute()
        {
            fs.createFile(path);
        }
    }
}