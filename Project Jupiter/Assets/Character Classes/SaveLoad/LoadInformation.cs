using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation : MonoBehaviour
{
   public static void LoadAllInformation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");
        GameInformation.Dextarity = PlayerPrefs.GetInt("Dextarity");
        GameInformation.Constitution = PlayerPrefs.GetInt("CONSTITUTION");
        GameInformation.Intelegence = PlayerPrefs.GetInt("INTELEGENCE");
        GameInformation.Wisdom = PlayerPrefs.GetInt("WISDOM");
        GameInformation.Charisma = PlayerPrefs.GetInt("CHARISMA");
        

    }
}
