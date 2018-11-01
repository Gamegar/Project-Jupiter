using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Platform : MonoBehaviour
{

    [SerializeField] private string newLevel;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Random random = new Random();
            int randomNumber = Random.Range(0, 100);

            if (randomNumber <= 4)
            {
                SceneManager.LoadScene( newLevel);

            }

            else
            {


            }
            Debug.Log("erroererer");
        }
    }


}
