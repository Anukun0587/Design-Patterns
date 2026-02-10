namespace Chain_of_Responsibility.handler.concrete_handler
{
    public class AdminReview : Recovery
    {
        public override void handle(string requestType)
        {
            Console.WriteLine("[Success] ส่งคำขอให้เจ้าหน้าที่ตรวจสอบเอกสารยืนยันตัวตนเรียบร้อย");
            base.handle(requestType);
        }
    }
}