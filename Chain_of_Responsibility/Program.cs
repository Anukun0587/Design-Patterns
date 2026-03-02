using Chain_of_Responsibility.Handler;
using Chain_of_Responsibility.context;

namespace Chain_of_Responsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILoanHandler credit = new CreditScoreHandler();
            ILoanHandler income = new IncomeHandler();
            ILoanHandler debt = new DebtHandler();
            ILoanHandler approval = new ApprovalHandler();

            credit.setNext(income).setNext(debt).setNext(approval);

            run(credit, "TEST 1: อนุมัติ", new LoanContext("สมชาย ใจดี", 500000, 780, 50000, 8000));

            run(credit, "TEST 2: Credit Score ต่ำ", new LoanContext("สมหญิง รักเงิน", 200000, 520, 30000, 5000));

            run(credit, "TEST 3: วงเงินสูงเกินไป", new LoanContext("มานะ อยากรวย", 5000000, 700, 25000, 3000));

            run(credit, "TEST 4: DTI สูงเกินไป", new LoanContext("วิชัย หนี้ท่วม", 300000, 650, 30000, 18000));

        }
        public static void run(ILoanHandler handler, string title, LoanContext ctx)
        {
            Console.WriteLine($"\n===== {title} =====");
            try
            {
                handler.handle(ctx);
            }
            catch (Exception e)
            {
                Console.WriteLine($"ปฏิเสธ: {e.Message}");
            }
        }
    }
}