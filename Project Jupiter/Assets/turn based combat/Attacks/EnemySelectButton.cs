using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelectButton : MonoBehaviour
{
    public GameObject enemyPreFab;

    public void SelectEnemy() {

        GameObject.Find("BattleManager").GetComponent<BattleStateMachine>().Input2(enemyPreFab);
    }
}
