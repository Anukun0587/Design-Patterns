using Chain_of_Responsibility.context;

namespace Chain_of_Responsibility.Handler
{
    public interface ILoanHandler
    {
        public ILoanHandler setNext(ILoanHandler next);
        public void handle(LoanContext ctx);
    }
}