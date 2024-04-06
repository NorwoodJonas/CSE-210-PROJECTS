abstract class GenericThing //this allows me to have an array of things in an area with all the same functions I can call
{ //You will see
protected string name;
protected string description;
protected int health; //All things have health, maybe a portal will have way more health but IDK
protected List<string> status; //Contains statii such as poisened, fired, depressed, encumbered, etc.
protected string location; //A string describing location, it is assumed you can access all things in an area
protected int weight; //Because characters should have a carrying capacity
protected int[] baseDamage; //Base damage, based on strength
protected int wieldliness; //How easy it is to hit something with the weapon
protected string[] damageType; //Types of damage inflicted, emotional damage should be a fun mechanic
protected int height;
protected int width;
protected int girth; //girth, width, and height approximate a box
protected int strength; //athletics should be based off of weight and strength
protected int agility;
protected int speech;
protected int streetSmarts;
protected int bookSmarts;
protected int magicAffinity;
protected int areaNumber;

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
    return; //why should you be able to damage a GenericThing?
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
    return description + location;
}

public void ChangeLocation() //changes location to wherever
{

}
}