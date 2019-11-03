using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IncreasesExperience 
{
    private static LevelUp levelUpScript = new LevelUp();
    private static int expToGive;

    public static void AddExperience() {
        expToGive = GameInformation.PlayerLevel * 100;

        GameInformation.CurrentExp += expToGive;

        CheckifPlayerLeveled();
        Debug.Log(expToGive);
    }
    private static void CheckifPlayerLeveled()
    {
        if (GameInformation.CurrentExp >= GameInformation.RequiredExp)
        {
            //level up
            levelUpScript.LevelupCharacter();
        }

    }
    


}
