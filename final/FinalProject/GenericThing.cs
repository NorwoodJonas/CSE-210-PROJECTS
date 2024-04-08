using System.Collections.Specialized;

class GenericThing //this allows me to have an array of things in an area with all the same functions I can call
{ //You will see
protected List<GenericThing> inventory = new(); //Don't you love it when a class contains a list of it's own things?
protected string name = "";
protected string description = "";
protected int health = 0; //All things have health, maybe a portal will have way more health but IDK
protected List<string> status = new(); //Contains statii such as poisened, fired, depressed, encumbered, etc.
protected string location = ""; //A string describing location, it is assumed you can access all things in an area
protected int weight = 0; //Because characters should have a carrying capacity
protected int[] baseDamage = {0}; //Base damage, based on strength
protected int wieldliness = 0; //How easy it is to hit something with the weapon
protected string[] damageType = {""}; //Types of damage inflicted, emotional damage should be a fun mechanic
protected int height = 0;
protected int width = 0;
protected int girth = 0; //girth, width, and height approximate a box
protected int strength = 0; //athletics should be based off of weight and strength
protected int agility = 0;
protected int speech = 0;
protected int streetSmarts = 0;
protected int bookSmarts = 0;
protected int magicAffinity = 0;
protected int areaNumber = 0;
protected int strengthBonus = 0;
protected int healthBonus = 0;
protected int speechBonus = 0;
protected Commanding commands;

public GenericThing(Commanding c)
{
    commands = c;
}

public virtual void WhatsUp() //I don't want to have to mark these as virtual tbh
{
    Console.WriteLine($"This is just a {name}, how would you talk to it?");
}

public GenericThing(Commanding c, string name, string description, string location)
{
    commands = c;
    this.name = name;
    this.description = description;
    this.location = location;
}

public GenericThing(string name) //Please don't use this, it only is for nothing
{
    this.name = name;
    this.description = "This is nothing, the programmer was being lazy.";
    this.location = "nowhere";
    commands = new Commanding();
}

public GenericThing()
{
    commands = new Commanding();
}

public int GetHealth()
{
    return health;
}

public int AreaNum()
{
    return areaNumber;
}

public string GetName()
{
    return name;
}

public void Damage(int damage, string type)
{
    health -= damage;
    //If health is less than 0, destry the item.
    return; //why should you be able to damage a GenericThing? Because everything has health.
} //damage type affects how much damage is dealt.

public virtual void Use() //Does whatever this item does, should be implemented with all GenericThings
{
    Console.WriteLine($"Wow, you are really using that {name}..."); //Not all things have useful things to do, if I forget to implement it then we have this message.
}

public virtual void Heal(int amount)
{
    return;
}

public string DescribeGenericThing()
{
    return description + " " + location;
}

public void ChangeLocation() //changes location to wherever
{

}

public void Give(GenericThing shiny)
{
    inventory.Add(shiny);
}

public int GetStrength()
{
    int te = 0;
    foreach(GenericThing g in inventory)
    {
        te += g.getStrengthBonus();
    }
    return strength + te;
}

public int getStrengthBonus()
{
    return strengthBonus;
}

public int getHealthBonus()
{
    return healthBonus;
}

public void activateItems()
{
    foreach(GenericThing g in inventory)
    {
        health += g.getHealthBonus();
        strength += g.getStrengthBonus();
    }
}
}