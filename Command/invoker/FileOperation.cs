using Command.command;

namespace Command.invoker
{
    public class FileOperation
    {
        private ICommand? command;

        public void setCommand(ICommand command)
        {
            this.command = command;
        }

        public void executeCommand()
        {
            command?.execute();
        }
    }
}