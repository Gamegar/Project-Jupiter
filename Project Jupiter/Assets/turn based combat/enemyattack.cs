using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{

    private BattleStateMachine BSM;

    public enemyattack enemy;
    public enum TurnState
    {
        PROCESSING,
        CHOOSEACTION,
        WAITING,
        ACTION,
        DEAD

    }

    public TurnState currentState;

    // progressbar

    private float cur_cooldown = 0.0f;
    private float max_cooldown = 5.0f;
    // Start is called before the first frame update
    // Start is called before the first frame update

    private Vector3 StartPosition;


    //action code
    private bool actionStarted = false;

    private float animSpeed = 5f;
    public GameObject HeroToAttack;

    void Start()
    {
        currentState = TurnState.PROCESSING;
        BSM = GameObject.Find("BattleManager").GetComponent<BattleStateMachine>(); 
        StartPosition = transform.position;
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
            case (TurnState.CHOOSEACTION):

                ChooseAction();
                currentState = TurnState.WAITING;
                break;


        }
        switch (currentState)
        {
            case (TurnState.WAITING):

                currentState = TurnState.ACTION;


                break;


        }
       
        switch (currentState)
        {
            case (TurnState.ACTION):
                StartCoroutine(TimeForAction());
                

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
        cur_cooldown = cur_cooldown + Time.deltaTime;
      
       
        if (cur_cooldown >= max_cooldown)
        {
            currentState = TurnState.CHOOSEACTION;

        }
    }

    void ChooseAction() {

        HandelTurns myAttack = new HandelTurns();
        myAttack.Attacker = enemy.name;
        myAttack.AttacksGameObject = this.gameObject;
        myAttack.AttackersTarget = BSM.HerosInGame[Random.Range(0, BSM.HerosInGame.Count)];
        BSM.CollectActions(myAttack);
        myAttack.Type = "enemy";
    }
    private IEnumerator TimeForAction()
    {
        if (actionStarted){
           yield break;
        }
        actionStarted = true;
        //animate
        Vector3 heroPosition = new Vector3 (HeroToAttack.transform.position.x-1.5f, HeroToAttack.transform.position.y, HeroToAttack.transform.position.z);
        while (MoveTowardsEnemy(heroPosition)) {
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);


        Vector3 firstPosition = StartPosition;
        while (MoveTowardsEnemy(firstPosition)){ yield return null; }
        //remove attacing enemy
        BSM.performList.RemoveAt(0);
        //resets BSM
        BSM.BattleStates = BattleStateMachine.PreformAction.WAIT;
        //end BMS
            actionStarted = false;
        cur_cooldown = 0f;
        max_cooldown = 6f;
        currentState = TurnState.PROCESSING;
    }
    private bool MoveTowardsEnemy(Vector3 target) {
        return target!=(transform.position=Vector3.MoveTowards(transform.position,target,animSpeed*Time.deltaTime));
    }
}
