﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class playermovment : MonoBehaviour {
public GameObject FloatingTextPrefab;
    public GameObject prefab;
    



    [SerializeField]
    private float speed;

    private Vector2 direction;
    private Vector3 enc;
    // Use this for initialization
    void Start() {
        direction = Vector2.up;
        




    }

    // Update is called once per frame
    void Update() {

        GetInput();
        Move();
        Vector3 movment = new Vector3(Input.GetAxis("MoveHorizontal"), Input.GetAxis("MoveVertical"),0.0f);
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;

        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;

           
          
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
         
          

        }
    }
    void ShowFloatingText()
    {
        Instantiate(FloatingTextPrefab, transform);

    }


 
}

