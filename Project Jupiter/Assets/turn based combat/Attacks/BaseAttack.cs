using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class BaseAttack : MonoBehaviour
{
    public string attackName;

    public int attackDamage;//base dmg = 5 +(lv*str)

    public int attackCost;//for spells and abilities (MP)


}
