using Chain_of_Responsibility.context;

namespace Chain_of_Responsibility.Handler
{
    public class ApprovalHandler : LoanHandler
    {
        public override void handle(LoanContext ctx)
        {
            double rate = ctx.getCreditScore() switch
            {
                >= 750 => 0.045,
                >= 700 => 0.065,
                >= 650 => 0.085,
                _ => 0.110
            };

            int months = Math.Clamp((int)(ctx.getAmount() / (ctx.getIncome() * 0.4)), 12, 360);
            double monthlyRate = rate / 12;
            double payment = ctx.getAmount() * (monthlyRate * Math.Pow(1 + monthlyRate, months)) / (Math.Pow(1 + monthlyRate, months) - 1);

            Console.WriteLine($"\nอนุมัติสินเชื่อ : {ctx.getName()}");
            Console.WriteLine($"วงเงินกู้ : {ctx.getAmount():N0} บาท");
            Console.WriteLine($"อัตราดอกเบี้ย : {rate:P1} ต่อปี");
            Console.WriteLine($"ระยะเวลาผ่อน : {months} เดือน ({months / 12} ปี)");
            Console.WriteLine($"ค่างวด/เดือน : {payment:N2} บาท");
            base.handle(ctx);
        }
    }
}