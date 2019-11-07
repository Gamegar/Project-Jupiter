using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turns : MonoBehaviour
{
    private BattleStateMachine BSM;
    public BasePlayer Cler;
    //naming and calling a base class

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

    private float cur_cooldown = 0f;
    private float max_cooldown = 5f;
    public Image ProgressBar;
    public GameObject Selector;

    

    //IeNumerator
    public GameObject EnemyToAttack;
    private bool actionStarted=false;
    private Vector3 startPosition;
    private float animSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        cur_cooldown = Random.Range(0.1f, 2.5f);
        Selector.SetActive(false);
        BSM = GameObject.Find("BattleManager").GetComponent<BattleStateMachine>();
        currentState = TurnState.PROCESSING;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentState);
        switch (currentState)
        {
            case (TurnState.PROCESSING):
              

                    UpgradeProgressBar();
                

                break;


                

            case (TurnState.ADDTOLIST):

                BSM.HerosToManage.Add(this.gameObject);
                Debug.Log(BSM);
                currentState = TurnState.WAITING;
                break;

            case (TurnState.WAITING):

                //idle

                break;



            case (TurnState.ACTION):

                StartCoroutine(TimeForAction());


                break;

 case (TurnState.SELECTION):
                
                
                break;





            case (TurnState.DEAD):
                break;

                    }
        
    }

    void UpgradeProgressBar()
    {
        cur_cooldown = cur_cooldown + Time.deltaTime;
        float calc_cooldown = cur_cooldown / max_cooldown;
        ProgressBar.transform.localScale = new Vector3(Mathf.Clamp(calc_cooldown,0, 1), ProgressBar.transform.localScale.y, ProgressBar.transform.localScale.z);
        if (cur_cooldown >= max_cooldown)
        {
            currentState = TurnState.ADDTOLIST;

        }
    }


    private IEnumerator TimeForAction()
    {
        if (actionStarted)
        {
            yield break;
        }
        actionStarted = true;
        //animate
        Vector3 enemyPosition = new Vector3(EnemyToAttack.transform.position.x + 1.5f, EnemyToAttack.transform.position.y, EnemyToAttack.transform.position.z);
        while (MoveTowardsEnemy(enemyPosition))
        {
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);


        Vector3 firstPosition = startPosition;
        while (MoveTowardsEnemy(firstPosition)) { yield return null; }
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
    private bool MoveTowardsEnemy(Vector3 target)
    {
        return target != (transform.position = Vector3.MoveTowards(transform.position, target, animSpeed * Time.deltaTime));
    }

    private bool MoveTowardStart(Vector3 target)
    {

        return target != (transform.position = Vector3.MoveTowards(transform.position, target, animSpeed * Time.deltaTime));

    }
    public void TakeDamage(float getDamageAmount)
    {

        -= getDamageAmount;
        if (<=0) {
            currentState = TurnState.DEAD;
        }
    }

}
