using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BattleStateMachine : MonoBehaviour
{
    private bool hasAddedExp = false;


    public enum PreformAction
    {
        WAIT, TAKEFACTION, PERFORMACTION, VICTORY
    }
    public PreformAction BattleStates;

    public List<HandelTurns> performList = new List<HandelTurns>();

    public List<GameObject> HerosInGame = new List<GameObject>();

    public List<GameObject> EnemiesInBattle = new List<GameObject>();

    //ienume
    public GameObject EnemyToAttack;
    private bool actionStarted = false;
    private Vector3 StartPosition;
    private float animSpeed = 10f;


    public enum heroGUI
    {

        ACTIVE, WAITING, INPUT1, INPUT2, DONE

    }

    public heroGUI HeroInput;

    public List<GameObject> HerosToManage = new List<GameObject>();
    private HandelTurns HeroChoice;

    public GameObject EnemyButton;

    public Transform Spacer;

    public GameObject AttackPanel;
    public GameObject EnemySelectPanel;



    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        BattleStates = PreformAction.WAIT;
        EnemiesInBattle.AddRange(GameObject.FindGameObjectsWithTag("enemy"));
        HerosInGame.AddRange(GameObject.FindGameObjectsWithTag("Player"));
        EnemyButtons();
        HeroInput = heroGUI.ACTIVE;

        AttackPanel.SetActive(false);
        EnemySelectPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (BattleStates)
        {
            case (PreformAction.WAIT):
                if (performList.Count > 0)
                {

                    BattleStates = PreformAction.TAKEFACTION;
                }
                if (performList.Count == 0)
                {
                    HerosInGame.AddRange(GameObject.FindGameObjectsWithTag("Player"));
                }

                break;

            case (PreformAction.TAKEFACTION):

                GameObject performer = GameObject.Find(performList[0].Attacker);
                if (performList[0].Type == "enemy")
                {
                    enemyattack EAK = performer.GetComponent<enemyattack>();
                    EAK.HeroToAttack = performList[0].AttackersTarget;
                    EAK.currentState = enemyattack.TurnState.ACTION;


                }

                if (performList[0].Type == "Hero")
                {
                    Turns TU = performer.GetComponent<Turns>();
                    TU.EnemyToAttack = performList[0].AttackersTarget;
                    TU.currentState = Turns.TurnState.ACTION;



                }
                BattleStates = PreformAction.PERFORMACTION;
                break;

            case (PreformAction.PERFORMACTION):


                break;

            case (PreformAction.VICTORY):
                if (!hasAddedExp)
                {
                    IncreasesExperience.AddExperience();
                    hasAddedExp = true;
                }
                break;
        }

        switch (HeroInput)
        {
            case (heroGUI.ACTIVE):

                if (HerosToManage.Count > 0)
                {

                    HerosToManage[0].transform.Find("Selector").gameObject.SetActive(true);
                    AttackPanel.SetActive(true);
                    HeroChoice = new HandelTurns();
                    HeroInput = heroGUI.WAITING;


                }

                break;

            case (heroGUI.WAITING):
                //idle



                break;



            case (heroGUI.DONE):

                HeroInputDone();

                break;

            
        }

    }

    public void CollectActions(HandelTurns input)
    {

        performList.Add(input);

    }

    void EnemyButtons()
    {
        foreach (GameObject enemy in EnemiesInBattle)
        {

            GameObject newButton = Instantiate(EnemyButton) as GameObject;

            EnemySelectButton button = newButton.GetComponent<EnemySelectButton>();

            enemyattack cur_enemy = enemy.GetComponent<enemyattack>();

            Text buttonText = newButton.transform.Find("Text").gameObject.GetComponent<Text>();
            buttonText.text = cur_enemy.enemy.name;

            button.enemyPreFab = enemy;
            newButton.transform.SetParent(Spacer, false);
        }

    }

    public void Input1()
    {

        HeroChoice.Attacker = HerosToManage[0].name;

        Debug.Log(HeroChoice.Attacker);

        HeroChoice.AttacksGameObject = HerosToManage[0];
        HeroChoice.Type = "Hero";

        AttackPanel.SetActive(false);
        EnemySelectPanel.SetActive(true);

    }

    public void Input2(GameObject choosenEnemy)
    {

        HeroChoice.AttackersTarget = choosenEnemy;
        HeroInput = heroGUI.DONE;
    }
    void HeroInputDone()
    {
        performList.Add(HeroChoice);
        EnemySelectPanel.SetActive(false);
        HerosToManage[0].transform.Find("Selector").gameObject.SetActive(false);
        HerosToManage.RemoveAt(0);
        HerosInGame.RemoveRange(0, 0);
        HeroInput = heroGUI.ACTIVE;
        BattleStates = PreformAction.WAIT;




    }

   

}