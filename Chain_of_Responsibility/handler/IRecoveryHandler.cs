namespace Chain_of_Responsibility.handler
{
    public interface IRecoveryHandler
    {
        public IRecoveryHandler setNext(IRecoveryHandler handler);
        public void handle(string requestType);
    }
}