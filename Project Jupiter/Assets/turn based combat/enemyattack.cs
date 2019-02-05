using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{
    public enum TurnState
    {
        PROCESSING,
        ADDTOLIST,
        WAITING,
        SELECTION,
        ACTION,
        DEAD

    }

    public TurnState currentState;

    // progressbar

    private float cur_cooldown = 0.0f;
    private float max_cooldown = 0.0f;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        currentState = TurnState.PROCESSING;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case (TurnState.PROCESSING):

                UpgradeProgressBar();


                break;
        }
        switch (currentState)
        {
            case (TurnState.ADDTOLIST):
                break;


        }
        switch (currentState)
        {
            case (TurnState.WAITING):
                break;


        }
        switch (currentState)
        {
            case (TurnState.SELECTION):
                break;


        }
        switch (currentState)
        {
            case (TurnState.ACTION):
                break;


        }
        switch (currentState)
        {
            case (TurnState.DEAD):
                break;


        }
    }

    void UpgradeProgressBar()
    {
        cur_cooldown = cur_cooldown - Time.deltaTime;
       
       
        if (cur_cooldown >= max_cooldown)
        {
            currentState = TurnState.ADDTOLIST;

        }
    }
}
