namespace Chain_of_Responsibility.handler.concrete_handler
{
    public class SMSVerify : Recovery
    {
        public override void handle(string requestType)
        {
            if (requestType == "sms")
            {
                Console.WriteLine("[Success] รหัส OTP ถูกส่งไปที่เบอร์มือถือของคุณแล้ว");
            }
            else
            {
                Console.WriteLine("[Log] SMS ทำงานไม่ได้... ส่งต่อให้ระบบคำถามความปลอดภัย");
                base.handle(requestType);
            }
        }
    }
}