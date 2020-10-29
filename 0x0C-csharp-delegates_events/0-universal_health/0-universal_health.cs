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

    /// <summary>
    /// test
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}