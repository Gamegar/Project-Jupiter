using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class BaseCleric : BaseCharacterClass
{


    

        
    public BaseCleric()
    {
        CharacterClassNames = "Cleric";
        CharacterClassDescription = "holy healer";
        Constitution = 14;
        Strength = 14;
        Dextarity = 10;
        Wisdom = 16;
        Intelegence = 13;
        Charisma = 10;
        HP = 30 + (1 * Constitution);
    }

   
}
    

