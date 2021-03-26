using System;

/// <summary>
/// test
/// </summary>
class Player
{
    //Test
    private string name;
    //Test
    private float maxHp;
    //Test
    private float hp;

    /// <summary>
    /// test
    /// </summary>
    /// <param name="name">test</param>
    /// <param name="maxHp">test</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
        this.name = name;
    }
    public delegate void CalculateHealth(float amount);

    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{this.name} takes {damage} damage!");
        ValidateHP(this.hp - damage);
    }
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{this.name} heals {heal} HP!");
        ValidateHP(this.hp + heal);
    }
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }
    /// <summary>
    /// test
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
