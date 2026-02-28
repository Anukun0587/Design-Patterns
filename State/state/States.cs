using State.context;

namespace State.state
{
    public abstract class States
    {
        protected Heroine heroine = null!;
        private string? name;

        public void setHeroine(Heroine heroine)
        {
            this.heroine = heroine;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string? getName()
        {
            return name;
        }

        public abstract void talk();
        public abstract void giveGift();
        public abstract void ignore();
        public abstract void confess();
    }
}