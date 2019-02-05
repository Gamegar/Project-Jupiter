using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability1 : MonoBehaviour
{
    public int damage;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    private void Update()
    {
        for (int i = 0; i < 0; i++) { }

        enemy1.GetComponent<BStats>().health -= damage;
        enemy2.GetComponent<BStats>().health -= damage;
        enemy3.GetComponent<BStats>().health -= damage;
        enemy4.GetComponent<BStats>().health -= damage;

    }

}
