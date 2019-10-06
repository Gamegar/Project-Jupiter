﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWizard : BaseCharacterClass
{

    public  BaseWizard()
    {
        CharacterClassNames = "Wizard";
        CharacterClassDescription = "Squish caster";
        Constitution = 8;
        Strength = 8;
        Dextarity = 14;
        Wisdom = 15;
        Intelegence = 17;
        Charisma = 10;
    }
}
