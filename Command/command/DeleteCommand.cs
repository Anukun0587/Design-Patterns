using Command.receiver;

namespace Command.command
{
    public class DeleteCommand : ICommand
    {
        private FileSystemService fs;
        private string path;

        public DeleteCommand(FileSystemService filesystem, string filePath)
        {
            fs = filesystem;
            path = filePath;
        }

        public void execute()
        {
            fs.deleteFile(path);
        }
    }
}