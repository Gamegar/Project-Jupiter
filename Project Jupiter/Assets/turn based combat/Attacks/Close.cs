using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public GameObject Panel;
    //create the varable for modification

    public void ClosePanel()
    {

        if (Panel == true)
        {
            Panel.SetActive(false);
        }

    }


}
