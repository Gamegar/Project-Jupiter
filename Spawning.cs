using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour {

    public GameObject Enemy;
    public GameObject Enemy2;
    float randX,rud;
    Vector2 whereToSpawn;
    //public float spawnRate = 0.2f;
   // float nextSpawn = 0.0f;



    //generate random number when run 
 
    // Use this for initialization
    void Start () {
		rud = UnityEngine.Random.Range(0,100);
	
        if (rud >= 50)
        {
            randX = -13.3f;
            whereToSpawn = new Vector2 (randX, transform.position.y);
            Instantiate(Enemy, whereToSpawn, Quaternion.identity);
        }
        if (rud <= 49)
        {
            randX = -13.3f;
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(Enemy2, whereToSpawn, Quaternion.identity);


        }}

    // Update is called once per frame
    void Update() {

    }
    
	
}
