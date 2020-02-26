﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public float speed;
    private Transform target;
   
    // Use this for initialization
    void Start()
    {
        //declares target
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //Moves towards target
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
          
    }

}
