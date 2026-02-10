namespace Chain_of_Responsibility.handler
{
    public abstract class Recovery : IRecoveryHandler
    {
        private IRecoveryHandler? nextHandler;

        public IRecoveryHandler setNext(IRecoveryHandler handler)
        {
            this.nextHandler = handler;
            return nextHandler;
        }

        public virtual void handle(string requestType)
        {
            if (nextHandler != null)
            {
                nextHandler.handle(requestType);
            }
        }
    }
}