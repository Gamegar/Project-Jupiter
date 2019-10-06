using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : MonoBehaviour
{

   Random random = new Random();
    int se = Random.Range(0, 100);
  //generates a random number between 0-100 to the variable se

    public GameObject running; 
    //creates a object 


    // Start is called before the first frame update
   public void RunAttempt()
    {
        if (se <= 51){
            running.SetActive(true);
            //when number is or bigger than 51 set true
        }
//
        else { }
      //  move to the previous sene when number is lower than 51
    }

    // Update is called once per frame
   
}
