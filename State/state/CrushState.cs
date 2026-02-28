namespace State.state
{
    public class CrushState : States
    {
        public CrushState()
        {
            setName("คนคุย");
        }

        public override void talk()
        {
            heroine.addScore(10);
            Console.WriteLine($"{heroine.getName()}: ดีใจจังที่เธอทักมา... ฉันรอคุยกับเธออยู่นะ (คะแนนความชอบ + 10)");
        }

        public override void giveGift()
        {
            heroine.addScore(20);
            Console.WriteLine($"{heroine.getName()}: น่ารักจัง ซื้อมาฝากด้วยเหรอ เขินนะเนี่ย (คะแนนความชอบ + 20)");
        }

        public override void ignore()
        {
            heroine.addScore(-20);
            Console.WriteLine($"{heroine.getName()}: ทำไมช่วงนี้เย็นชาจัง... ฉันทำอะไรผิดรึเปล่า? (คะแนนความชอบ - 20)");

            if (heroine.getScore() < 40)
            {
                Console.WriteLine($"{heroine.getName()}: เธอคงไม่ได้คิดอะไรกับฉันจริงๆ สินะ...");
                heroine.changeState(new FriendState());
            }
        }

        public override void confess()
        {
            if (heroine.getScore() >= 100)
            {
                Console.WriteLine($"{heroine.getName()}: อื้อ... ฉันก็ชอบเธอเหมือนกัน ฝากตัวด้วยนะ!");
                heroine.changeState(new LoverState());
            }
            else
            {
                Console.WriteLine($"{heroine.getName()}: ข-ขอเวลาฉันคิดดูก่อนนะ (คะแนนยังไม่ถึง 100)");
            }
        }
    }
}