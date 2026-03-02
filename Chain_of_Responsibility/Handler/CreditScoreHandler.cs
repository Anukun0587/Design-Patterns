using Chain_of_Responsibility.context;

namespace Chain_of_Responsibility.Handler
{
    public class CreditScoreHandler : LoanHandler
    {
        public override void handle(LoanContext ctx)
        {
            if(ctx.getCreditScore() < 600)
            {
                throw new Exception($"Credit Score {ctx.getCreditScore()} ต่ำกว่าเกณฑ์ 600");
            }

            Console.WriteLine($"{ctx.getName()} : Credit Score {ctx.getCreditScore()} ผ่าน");
             base.handle(ctx);
        }
    }
}