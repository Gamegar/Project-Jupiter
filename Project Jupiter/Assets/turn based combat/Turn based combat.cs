using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnbasedcombat : MonoBehaviour {
   // private BattleStart
   public enum BattleStates
    {
        Start,
        PlayerChoice,
        ClaculatDmg,
        EnemyChoice,
        AddStatEffects,
        Lose,
        Win
    }



    // Use this for initialization

    private BattleStates currentState;

	void Start () {
        currentState = BattleStates.Start;
	}
	
	// Update is called once per frame
	void Update () {
        
        //battle set up function
        switch (currentState)
        {
            case (BattleStates.Start):
                break;
            case (BattleStates.PlayerChoice):
                break;
            case (BattleStates.EnemyChoice):
                break;
            case (BattleStates.ClaculatDmg):
                break;
            case (BattleStates.AddStatEffects):
                break;
            case (BattleStates.Lose):
                break;
            case (BattleStates.Win):
                break;
        }
	}
    private void OnGUI()
    {if (GUILayout.Button("Next State"))
        {
            if (currentState == BattleStates.Start)
            {
                currentState = BattleStates.PlayerChoice;

            }
            else  if (currentState == BattleStates.PlayerChoice)
            {
                currentState = BattleStates.EnemyChoice;

            }
            else if (currentState == BattleStates.EnemyChoice)
            {
                currentState = BattleStates.Lose;

            }
            else if (currentState == BattleStates.Lose)
            {
                currentState = BattleStates.Win;

            }
            else if (currentState == BattleStates.Win)
            {
                currentState = BattleStates.Start;

            }

        }
        
    }
}
