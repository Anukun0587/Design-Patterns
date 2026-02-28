namespace State.state
{
    public class FriendState : States
    {
        public FriendState()
        {
            setName("เพื่อน");
        }

        public override void talk()
        {
            heroine.addScore(10);
            Console.WriteLine($"{heroine.getName()}: คุยกับเธอเนี่ยสนุกดีนะ (คะแนนความชอบ + 10)");
            CheckProgress();
        }

        public override void giveGift()
        {
            heroine.addScore(20);
            Console.WriteLine($"{heroine.getName()}: ว้าว ขอบใจนะ! ของชอบเลยล่ะ (คะแนนความชอบ + 20)");
            CheckProgress();
        }

        public override void ignore()
        {
            heroine.addScore(-15);
            Console.WriteLine($"{heroine.getName()}: อ้าว... เดินหนีไปเฉยเลย (คะแนนความชอบ - 15)");

            if (heroine.getScore() <= 0)
            {
                Console.WriteLine($"{heroine.getName()}: หยิ่งนักใช่มั้ย งั้นเราก็ไม่ต้องมารู้จักกันเลย!");
                heroine.resetScore();
                heroine.changeState(new StrangerState());
            }
        }

        public override void confess()
        {
            Console.WriteLine($"{heroine.getName()}: เอิ่ม... เราเป็นแค่เพื่อนกันดีกว่านะ (นกจังๆ!)");
        }

        private void CheckProgress()
        {
            if (heroine.getScore() >= 50)
            {
                heroine.changeState(new CrushState());
            }
        }
    }
}