using System;

namespace Enemies
{
    /// <summary>
    /// test
    /// </summary>
    public class Zombie
    {
        private int health;
        private string name = "(No name)";

        /// <summary>
        /// test
        /// </summary>
        /// <value>test</value>
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// test
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
        /// <summary>
        /// test
        /// </summary>
        /// <param name="value">test</param>
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
        /// <summary>
        /// test
        /// </summary>
        /// <returns>test</returns>
        public int GetHealth()
        {
            return this.health;
        }
        /// <summary>
        /// test
        /// </summary>
        /// <returns>test</returns>
        public override string ToString()
        {
            return $"Zombie Name: {this.Name} / Total Health: {this.GetHealth()}";
        }
    }
}