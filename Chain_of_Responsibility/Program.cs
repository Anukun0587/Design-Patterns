using Chain_of_Responsibility.handler;
using Chain_of_Responsibility.handler.concrete_handler;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // สร้างห่วงโซ่ของการกู้คืนรหัสผ่าน
            IRecoveryHandler email = new EmailVerify();
            IRecoveryHandler sms = new SMSVerify();
            IRecoveryHandler question = new QuestionVerify();
            IRecoveryHandler admin = new AdminReview();

            email.setNext(sms).setNext(question).setNext(admin);

            Console.WriteLine("=== กู้คืนรหัสผ่านผ่าน Email ===");
            email.handle("email");

            Console.WriteLine("\n=== กู้คืนรหัสผ่านผ่าน SMS ===");
            email.handle("sms");

            Console.WriteLine("\n=== กู้คืนรหัสผ่านผ่าน คำถามความปลอดภัย ===");
            email.handle("security-question");

            Console.WriteLine("\n=== กู้คืนรหัสผ่านโดยที่ไม่มีวิธีใดใช้ได้ ===");
            email.handle("none");
        }
    }
}