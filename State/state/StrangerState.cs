namespace State.state
{
    public class StrangerState : States
    {
        public StrangerState()
        {
            setName("คนแปลกหน้า");
        }

        public override void talk()
        {
            heroine.addScore(1);
            Console.WriteLine($"{heroine.getName()}: อ๋อ สวัสดีค่ะ... (คะแนนความชอบ + 1)");

            if (heroine.getScore() >= 3)
            {
                heroine.changeState(new FriendState());
            }
        }

        public override void giveGift()
        {
            Console.WriteLine($"{heroine.getName()}: เอ๊ะ... ให้ฉันทำไมคะ? เราเพิ่งเจอกันเองนะ (ปฎิเสธไม่ยอมรับของ)");
        }

        public override void ignore()
        {
            Console.WriteLine($"{heroine.getName()}: (เดินสวนกันไปเงียบๆ ไม่มีอะไรเกิดขึ้น)");
        }

        public override void confess()
        {
            Console.WriteLine($"{heroine.getName()}: ห๊ะ!? โรคจิตป่าวเนี่ย ({heroine.getName()} เดินหนี คุณโดนมองว่าแปลกประหลาด)");
        }
    }
}