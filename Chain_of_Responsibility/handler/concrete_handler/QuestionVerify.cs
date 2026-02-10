namespace Chain_of_Responsibility.handler.concrete_handler
{
    public class QuestionVerify : Recovery
    {
        public override void handle(string requestType)
        {
            if (requestType == "security-question")
            {
                Console.WriteLine("[Success] กรุณากรอกคำตอบสำหรับคำถาม: 'สัตว์เลี้ยงตัวแรกของคุณชื่ออะไร?'");
            }
            else
            {
                Console.WriteLine("[Log] จำคำตอบไม่ได้... ส่งต่อให้ Admin ตรวจสอบ");
                base.handle(requestType);
            }
        }
    }
}