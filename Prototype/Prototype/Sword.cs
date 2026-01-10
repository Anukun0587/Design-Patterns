using System;

namespace Prototypes
{
    public class Sword : IPrototype
    {
        private string damage;
        private string durability;

        public Sword(Sword prototype)
        {
            this.damage = prototype.damage;
            this.durability = prototype.durability;
        }

        public Sword(string damage, string durability)
        {
            this.damage = damage;
            this.durability = durability;
        }

        public virtual IPrototype Clone()
        {
            return new Sword(this);
        }

        public string Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public string Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Damage: {damage}, Durability: {durability}");
        }
    }
}