using System;

class Player
{
    private string name;
    private float maxHp;
    private float hp;

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

    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
    // public string name
    // {
    //     get => name;
    //     set
    //     {
    //         name = value;
    //     }
    // }
    // public float maxHp
    // {
    //     get => name;
    //     set
    //     {
    //         name = value;
    //     }
    // }
    // public float hp
    // {
    //     get => name;
    //     set
    //     {
    //         name = value;
    //     }
    // }
}