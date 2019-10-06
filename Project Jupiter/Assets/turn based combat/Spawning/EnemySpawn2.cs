using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn2 : MonoBehaviour {
    public GameObject Enemy;
    public GameObject Enemy2;
    public GameObject Enemy3;
    float randX, rud;
    Vector2 whereToSpawn;
    // Use this for initialization
    void Start () {
        rud = UnityEngine.Random.Range(0, 100);

        if (rud >= 75)
        {
            randX = -13.3f;
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(Enemy, whereToSpawn, Quaternion.identity);
        }
       if (rud <= 25)
        {
            randX = -13.3f;
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(Enemy2, whereToSpawn, Quaternion.identity);


        }
         else 
        {
            randX = -13.3f;
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(Enemy3, whereToSpawn, Quaternion.identity);


        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
