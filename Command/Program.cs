using Command.command;
using Command.invoker;
using Command.receiver;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            FileOperation fileOperation = new FileOperation();

            FileSystemService fileSystem = new FileSystemService();

            ICommand createCommand = new CreateCommand(fileSystem, "file1.txt");
            ICommand copyCommand = new CopyCommand(fileSystem, "file1.txt", "file2.txt");
            ICommand deleteCommand = new DeleteCommand(fileSystem, "file1.txt");
            ICommand archiveCommand = new ArchiveCommand(fileSystem, "file2.txt", "file2.zip");
            
            fileOperation.setCommand(createCommand);
            fileOperation.executeCommand();

            fileOperation.setCommand(copyCommand);
            fileOperation.executeCommand();

            fileOperation.setCommand(deleteCommand);
            fileOperation.executeCommand();

            fileOperation.setCommand(archiveCommand);
            fileOperation.executeCommand();
        }
    }
}