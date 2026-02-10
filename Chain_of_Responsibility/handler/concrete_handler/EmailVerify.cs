namespace Chain_of_Responsibility.handler.concrete_handler
{
    public class EmailVerify : Recovery
    {
        public override void handle(string requestType)
        {
            if (requestType == "email")
            {
                Console.WriteLine("[Success] ลิงก์กู้คืนถูกส่งไปที่ Email ของคุณแล้ว");
            }
            else
            {
                Console.WriteLine("[Log] Email ทำงานไม่ได้... ส่งต่อให้ระบบ SMS");
                base.handle(requestType);
            }
        }
    }
}