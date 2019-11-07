using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class BaseAttack : MonoBehaviour
{
    public string attackName;

    public float attackDamage;//base dmg = 5 +(lv*str)

    public float attackCost;//for spells and abilities (MP)


}
