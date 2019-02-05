using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BStats : MonoBehaviour
{
    //GameObject enemy;
    public int health = 3;
    private void Update()
    {
        if (health <= 0) {
            Destroy(this.gameObject);
        }    }
}
