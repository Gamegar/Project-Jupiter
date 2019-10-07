using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SaveInformation 
{
   
    public static void SaveAllInformation()
    {

        PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("STRENGTH", GameInformation.Strength);
        PlayerPrefs.SetInt("Dextarity", GameInformation.Dextarity);
        PlayerPrefs.SetInt("CONSTITUTION", GameInformation.Constitution);
        PlayerPrefs.SetInt("INTELEGENCE", GameInformation.Intelegence);

        PlayerPrefs.SetInt("WISDOM", GameInformation.Wisdom);
        PlayerPrefs.SetInt("CHARISMA", GameInformation.Charisma);
        Debug.Log("SAVED ALL");
    }

}
