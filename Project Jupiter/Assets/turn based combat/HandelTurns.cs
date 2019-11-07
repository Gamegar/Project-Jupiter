using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class HandelTurns
{


   public string Attacker; //name of attacker
    public string Type;
    public GameObject AttacksGameObject; //who is attacker
    public GameObject AttackersTarget; // is attacked


    public BaseAttack chossenAttack;
}
