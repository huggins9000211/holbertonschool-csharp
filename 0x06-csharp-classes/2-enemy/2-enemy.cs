using System;

namespace Enemies
{
    /// <summary>
    /// 
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// 
        /// </summary>
        public int health;
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
    }
}
