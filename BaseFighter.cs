using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFighter : ClassesPlayer
{
    public void FighterClass()
    {
        CharacterClassNames = "Fighter";
        CharacterClassDescription = "Balanced frontline fighter";
        Constitution = 16;
        Strength = 15;
            Dextarity = 12;
        Wisdom = 12;
        Intelegence = 10;
        Charisma = 12;
    }

}
