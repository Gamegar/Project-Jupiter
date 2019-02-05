using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basicattack : MonoBehaviour
{
    public int damage;
    public GameObject enemy1,enemy2,enemy3, enemy4;

    private void Update()
    {
     

         enemy1.GetComponent<BStats>().health -= damage;
         enemy2.GetComponent<BStats>().health -= damage;
         enemy3.GetComponent<BStats>().health -= damage;
         enemy4.GetComponent<BStats>().health -= damage;
    }
  
}
