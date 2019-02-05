using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScrean : MonoBehaviour {

    [SerializeField] private string newLeve;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {



            SceneManager.LoadScene(newLeve);

        }
        else
        {




            Debug.Log("ertro");
        }
    }


}
