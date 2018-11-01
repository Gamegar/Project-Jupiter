using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scean : MonoBehaviour
{

    [SerializeField] private string newLeve;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Random random = new Random();
            int randomNumber = Random.Range(0, 100);

            if (randomNumber < 5)
            {
                SceneManager.LoadScene(newLeve);

            }

           
            Debug.Log("erro");
        }
    }


}

