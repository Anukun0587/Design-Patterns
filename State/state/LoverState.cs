namespace State.state
{
    public class LoverState : States
    {
        public LoverState()
        {
            setName("แฟน");
        }

        public override void talk()
        {
            heroine.addScore(5);
            Console.WriteLine($"{heroine.getName()}: คุยกับเธอแล้วมีความสุขที่สุดเลย (คะแนนความชอบ + 5)");
        }

        public override void giveGift()
        {
            heroine.addScore(15);
            Console.WriteLine($"{heroine.getName()}: ขอบคุณนะ รักที่สุดเลย! (คะแนนความชอบ + 15)");
        }

        public override void ignore()
        {
            heroine.addScore(-30);
            Console.WriteLine($"{heroine.getName()}: นี่! ทำไมเดี๋ยวนี้ไม่ค่อยสนใจเค้าเลย โกรธแล้วนะ! (คะแนนความชอบ - 30)");

            if (heroine.getScore() < 50)
            {
                Console.WriteLine($"{heroine.getName()}: ถ้าเธอไม่ใส่ใจกันแบบนี้ เรากลับไปเป็นแค่เพื่อนเถอะ!");
                heroine.changeState(new FriendState());
            }
        }

        public override void confess()
        {
            Console.WriteLine($"{heroine.getName()}: บ้าเบ๋อออ เป็นแฟนกันแล้วยังจะมาบอกรักอะไรอีก เขินนะ!");
        }
    }
}