using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class Spoell //character class will have list of spoells
{ //like an item, but cast as a spoell
    Commanding commands;
    string spell; //choose private sometime
    int damage;
    int heal;
    int level;


    public Spoell(string spellName, Commanding earth, int d, int h, int l)
    {
        commands = earth; //This thing better make commands an object reference, not a copy of that object
        spell = spellName;
        damage = d;
        heal = h;
        level = l;
    }

    public void Cast(GenericThing g)
    { //does whatever spell does, heals, damages
        var rand = new Random();
        if(heal != 0)
        {
            if(rand.Next(level) * 10 > 0.5 * g.GetHealth())
            {
                g.Heal(rand.Next(level) * 10);
            }
        }
        if(damage != 0)
        {
            if(rand.Next(level) > 0.5 * g.GetStrength())
            {
                g.Damage(rand.Next(level) * 2, "spell");
            }
        }
    }
}