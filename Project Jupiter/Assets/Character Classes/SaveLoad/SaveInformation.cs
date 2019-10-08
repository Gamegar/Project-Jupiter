﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SaveInformation 
{
   
    public static void SaveAllInformation()
    {

        PlayerPrefs.SetInt("PLAYERLEVEL", Gameinfo.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", Gameinfo.PlayerName);
        PlayerPrefs.SetInt("STRENGTH", Gameinfo.Strength);
        PlayerPrefs.SetInt("Dextarity", Gameinfo.Dextarity);
        PlayerPrefs.SetInt("CONSTITUTION", Gameinfo.Constitution);
        PlayerPrefs.SetInt("INTELEGENCE", Gameinfo.Intelegence);

        PlayerPrefs.SetInt("WISDOM", Gameinfo.Wisdom);
        PlayerPrefs.SetInt("CHARISMA", Gameinfo.Charisma);
        Debug.Log("SAVED ALL");
    }

}
