using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp 
{
    public int maxPlayerLevel = 10;

 public void LevelupCharacter()
    {   //check if curr exp is greater that req exp

        if(GameInformation.CurrentExp > GameInformation.RequiredExp)
        {
            GameInformation.CurrentExp -= GameInformation.RequiredExp;

        }
        else
        {
            GameInformation.CurrentExp = 0;

        }
      if(GameInformation.PlayerLevel< maxPlayerLevel)
        {

            GameInformation.PlayerLevel += 1;
        }
        else
        {
            GameInformation.PlayerLevel = maxPlayerLevel;
        }

        //increase stats randomly


        //determin next exp required amount
        DeterminRequiredExp();

    }
    
    private void DeterminRequiredExp()
    {
        int temp = (GameInformation.PlayerLevel * 100) + 500;
        GameInformation.RequiredExp = temp;

    }
    private void DeterminIcreaseHealth()
    {

if(GameInformation.PlayerLevel == 5)
        {
            GameInformation.Constitution += 5;

        }
    }
}
