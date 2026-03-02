using Chain_of_Responsibility.context;

namespace Chain_of_Responsibility.Handler
{
    public class DebtHandler : LoanHandler
    {
        public override void handle(LoanContext ctx)
        {
            if (ctx.getDTL() > 0.50)
            {
                throw new Exception($"DTL {ctx.getDTL():P1} เกินเกณฑ์ 50%");
            }

            Console.WriteLine($"{ctx.getName()} : DTL {ctx.getDTL():P1} ผ่าน");
            base.handle(ctx);
        }
    }
}