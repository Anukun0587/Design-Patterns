using Chain_of_Responsibility.context;

namespace Chain_of_Responsibility.Handler
{
    public abstract class LoanHandler : ILoanHandler
    {
        private ILoanHandler? nextHandler;

        public ILoanHandler setNext(ILoanHandler next)
        {
            nextHandler = next;
            return nextHandler;
        }

        public virtual void handle(LoanContext ctx)
        {
            if (nextHandler != null)
            {
                nextHandler.handle(ctx);
            }
        }
    }
}