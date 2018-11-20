using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {
    private string playerName;
    private int playerLevel;
   // private BaseCharacterClass playerClass;
    private int strength;
    private int dextarity;
    private int constitution;
    private int intelegence;
    private int wisdom;
    private int charisma;

    public string PlayerName
    {
        get { return playerName;}
        set { playerName = value; }

    }
    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }

    }

    public int Constitution
    {
        get { return constitution; }
        set { constitution = value; }

    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }

    }

    public int Dextarity
    {
        get { return dextarity; }
        set { dextarity = value; }

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
}