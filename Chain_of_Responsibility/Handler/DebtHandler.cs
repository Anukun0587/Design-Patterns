using Chain_of_Responsibility.context;

namespace Chain_of_Responsibility.Handler
{
    public class DebtHandler : LoanHandler
    {
        public override void handle(LoanContext ctx)
        {
            if (ctx.getDTI() > 0.50)
            {
                throw new Exception($"DTI {ctx.getDTI():P1} เกินเกณฑ์ 50%");
            }

            Console.WriteLine($"{ctx.getName()} : DTI {ctx.getDTI():P1} ผ่าน");
            base.handle(ctx);
        }
    }
}