using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class BaseStatItem : BaseItem
{
    private int constitution;
    private int dexterity;
    private int intelegence;
    private int charisma;
    private int strength;
    private int wisdom;
    private int attackBonuse;

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
        set { intelegence = value; }
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

    public int AttackBonuse
    {
        get { return attackBonuse; }
        set { attackBonuse = value; }
    }

}
