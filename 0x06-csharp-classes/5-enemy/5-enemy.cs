using System;

namespace Enemies
{
    /// <summary>
    /// 
    /// </summary>
    public class Zombie
    {
        private int health;
        private string name = "(No name)";

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
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
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {
            return this.health;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            Console.WriteLine($"Zombie name: {this.Name} / Total Health: {this.GetHealth()}");
            return $"Zombie name: {this.Name} / Total Health: {this.GetHealth()}";
        }
    }
}