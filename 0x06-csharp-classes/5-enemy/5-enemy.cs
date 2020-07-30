using System;

namespace Enemies
{
    public class Zombie
    {
        private int health;
        private string name = "(No name)";

        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public Zombie()
        {
            this.health = 0;
        }
        public Zombie(int value)
        {
            if (value >= 0)
            {
                this.health = value;
            }
            else 
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
        public int GetHealth()
        {
            return this.health;
        }

        public override string ToString()
        {
            return $"Zombie name: {this.name} / Total Health: {this.health}";
        }
    }
}