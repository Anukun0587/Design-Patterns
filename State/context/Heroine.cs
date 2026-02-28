using State.state;

namespace State.context
{
    public class Heroine
    {
        private States? state;
        private string name { get; set; }
        private int score { get; set; } = 0;

        public Heroine(string name, States state)
        {
            this.name = name;
            changeState(state);
            showStatus();
        }

        public void changeState(States newState)
        {
            state = newState;
            state.setHeroine(this);
        }

        public void showStatus()
        {
            Console.WriteLine($"[สถานะ] {name} | ความสัมพันธ์: {state?.getName()} | คะแนนความชอบ: {score}");
        }

        public void talk()
        {
            state?.talk();
            showStatus();
        }

        public void giveGift()
        {
            state?.giveGift();
            showStatus();
        }

        public void ignore()
        {
            state?.ignore();
            showStatus();
        }

        public void confess()
        {
            state?.confess();
            showStatus();
        }

        public string getName()
        {
            return name;
        }
        public int getScore()
        {
            return score;
        }
        public void addScore(int amount)
        {
            score += amount;
        }
        public void setScore(int newScore)
        {
            score = newScore;
        }
        public void resetScore()
        {
            score = 0;
        }
    }
}