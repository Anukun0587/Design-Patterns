using State.state;
using State.context;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ระบบความสัมพันธ์ (State Pattern)");

            Heroine alice = new Heroine("อลิซ", new StrangerState());

            // ━━━ [1] StrangerState ━━━
            Console.WriteLine("\n━━━ [1] StrangerState: ทดสอบทุก action ━━━");

            Console.WriteLine("\n→ ให้ของตอนยังไม่รู้จักกัน");
            alice.giveGift();

            Console.WriteLine("\n→ เมินสวนกันไป");
            alice.ignore();

            Console.WriteLine("\n→ บอกรักทันทีตอนเพิ่งเจอ");
            alice.confess();

            Console.WriteLine("\n→ คุย 3 ครั้ง → เปลี่ยนเป็นเพื่อน");
            alice.talk(); 
            alice.talk(); 
            alice.talk();

            // ━━━ [2] FriendState ━━━
            Console.WriteLine("\n━━━ [2] FriendState: ทดสอบทุก action ━━━");

            Console.WriteLine("\n→ บอกรักตอนเป็นเพื่อน (โดนนก)");
            alice.confess();

            Console.WriteLine("\n→ คุย (+10)");
            alice.talk();

            Console.WriteLine("\n→ ให้ของ (+20)");
            alice.giveGift();

            Console.WriteLine("\n→ เมินจนคะแนนติดลบ → กลับเป็นคนแปลกหน้า");
            alice.ignore();
            alice.ignore();
            alice.ignore();

            // ━━━ [3] จีบใหม่ → CrushState ━━━
            Console.WriteLine("\n━━━ [3] เริ่มจีบใหม่ → Friend → Crush ━━━");

            alice.talk(); 
            alice.talk(); 
            alice.talk();
            Console.WriteLine("\n กำหนดคะแนนให้เป็น 30 เพื่อทดสอบการเปลี่ยนสถานะจากเพื่อน → คนคุย");
            alice.setScore(30);
            alice.talk();     // +10 = 40
            alice.giveGift(); // +20 = 60 → CrushState

            // ━━━ [4] CrushState ━━━
            Console.WriteLine("\n━━━ [4] CrushState: ทดสอบทุก action ━━━");

            Console.WriteLine("\n→ คุย (+10)");
            alice.talk();

            Console.WriteLine("\n→ ให้ของ (+20)");
            alice.giveGift();

            Console.WriteLine("\n→ บอกรักตอนคะแนนไม่ถึง 100");
            alice.confess();

            Console.WriteLine("\n→ เมินจนกลับเป็นเพื่อน");
            Console.WriteLine("→ กำนดคะแนนให้เป็น 50 เพื่อทดสอบการเปลี่ยนสถานะจากคนคุย → เพื่อน");
            alice.setScore(50);
            alice.ignore();

            // ━━━ [5] บอกรักสำเร็จ → LoverState ━━━
            Console.WriteLine("\n━━━ [5] บอกรักสำเร็จ → เป็นแฟน ━━━");

            alice.changeState(new CrushState());
            alice.setScore(100);
            alice.confess();

            // ━━━ [6] LoverState ━━━
            Console.WriteLine("\n━━━ [6] LoverState: ทดสอบทุก action ━━━");

            Console.WriteLine("\n→ คุยกับแฟน (+5)");
            alice.talk();

            Console.WriteLine("\n→ ให้ของแฟน (+15)");
            alice.giveGift();

            Console.WriteLine("\n→ บอกรักทั้งที่เป็นแฟนแล้ว");
            alice.confess();

            Console.WriteLine("\n→ เมินแฟนจนกลับเป็นเพื่อน");
            alice.setScore(70);
            alice.ignore();
        }
    }
}