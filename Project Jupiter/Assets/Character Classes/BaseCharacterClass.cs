using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass
{
    private string characterClassName;

    private string characterClassDescription;

    //stats
    private int constitution;
    private int dexterity;
    private int intelegence;
    private int charisma;
    private int strength;
    private int wisdom;

    public string CharacterClassNames
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }
        public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }       
    public int Constitution
    {
        get { return constitution; }
        set { constitution = value; }
    }
    public int Dextarity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Intelegence
    {
        get { return intelegence; }
        set { intelegence= value; }
}
        public int Wisdom
    {
        get { return wisdom; }
        set { wisdom = value; }
    }
    public int Charisma
    {
        get { return charisma; }
        set { charisma = value; }
    }
}
