using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilitys1 : MonoBehaviour
{
    public GameObject Panel;
    //create the varable for modification

    void OpenPanel() {

        if(Panel != null){
            Panel.SetActive(true);
        }

    }
}
