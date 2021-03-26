using System;

/// <summary>
/// test
/// </summary>
enum Modifier
{
    Weak,
    Base,
    Strong
}
delegate float CalculateModifier(float baseValue, Modifier modifier);

class CurrentHPArgs : EventArgs
{
    public float currentHp { get; private set; }
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }

}

class Player
{
    //Test
    private string name;
    //Test
    private float maxHp;
    //Test
    private float hp;

    private string status;

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
        status = $"<name> is ready to go!";
        HPCheck = CheckStatus;
    }
    public delegate void CalculateHealth(float amount);

    public EventHandler<CurrentHPArgs> HPCheck;

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
            Console.WriteLine("Health has reached zero!");
        else
            Console.WriteLine("Health is low!");
    }
    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp/4)
            HPCheck = HPValueWarning;
        HPCheck(this, e);
    }
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
            Console.WriteLine(status);
        }
        if ((e.currentHp >= maxHp/2) && (e.currentHp < maxHp))
        {
            status = $"{name} is doing well!";
            Console.WriteLine(status);
        }
        if ((e.currentHp >= maxHp/4) && (e.currentHp < maxHp/2))
        {
            status = $"{name} isn't doing too great...";
            Console.WriteLine(status);
        }
        if ((e.currentHp > 0) && (e.currentHp < maxHp/4))
        {
            status = $"{name} needs help!";
            Console.WriteLine(status);
        }
        if (e.currentHp == 0)
        {
            status = $"{name} is knocked out!";
            Console.WriteLine(status);
        }
    }
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
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue / 2.0f;
        else if (modifier == Modifier.Strong)
            return baseValue * 1.5f;   
        else
            return baseValue;    
    }
    /// <summary>
    /// test
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
