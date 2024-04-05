using System.Runtime.CompilerServices;

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

    public void Cast()
    { //does whatever spell does, heals, damages
    }
}