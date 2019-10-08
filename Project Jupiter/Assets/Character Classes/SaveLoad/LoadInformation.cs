using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation : MonoBehaviour
{
   public static void LoadAllInformation()
    {
        Gameinfo.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        Gameinfo.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        Gameinfo.Strength = PlayerPrefs.GetInt("STRENGTH");
        Gameinfo.Dextarity = PlayerPrefs.GetInt("Dextarity");
        Gameinfo.Constitution = PlayerPrefs.GetInt("CONSTITUTION");
        Gameinfo.Intelegence = PlayerPrefs.GetInt("INTELEGENCE");
        Gameinfo.Wisdom = PlayerPrefs.GetInt("WISDOM");
        Gameinfo.Charisma = PlayerPrefs.GetInt("CHARISMA");
        

    }
}
