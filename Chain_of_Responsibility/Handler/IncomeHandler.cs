using Chain_of_Responsibility.context;

namespace Chain_of_Responsibility.Handler
{
    public class IncomeHandler : LoanHandler
    {
        public override void handle(LoanContext ctx)
        {
            if (ctx.getIncome() < 15000)
            {
                throw new Exception($"รายได้ {ctx.getIncome():N0} บาท ต่ำกว่าเกณฑ์");
            }

            if (ctx.getAmount() > ctx.getIncome() * 40)
            {
                throw new Exception($"วงเงิน {ctx.getAmount():N0} บาท สูงเกินไป");
            }

            Console.WriteLine($"{ctx.getName()} : รายได้ {ctx.getIncome():N0} บาท ผ่าน");
            base.handle(ctx);

        }
    }
}