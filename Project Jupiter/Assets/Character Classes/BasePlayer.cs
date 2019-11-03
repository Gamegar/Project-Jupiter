using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BasePlayer
{
    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int constitution;// health modifire
    private int dexterity; //dodge modifire
    private int intelegence; //cast arcane spells
    private int charisma; // resist holy magic
    private int strength; // physical dmg
    private int wisdom; // take less magic dmg and cast holy spells

    private int currentExp;
    private int requiredExp;

    private int gold; // curancy

    public int CurrentExp { get; set; }
    public int RequiredExp { get; set; }
    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }
    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }
    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
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

    public int Gold
    {
        get { return gold; }
        set { gold = value; }
    }

}