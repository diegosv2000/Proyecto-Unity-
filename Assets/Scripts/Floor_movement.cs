﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_movement : MonoBehaviour
{
    public Rigidbody rbd;
    private float speed = 5;
    
    bool time=true;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
        
        StartCoroutine(Stop());
    }
    IEnumerator Stop()
    {
        time = true;
        yield return new WaitForSeconds(3);
        time = false;
        yield return new WaitForSeconds(3);
        StartCoroutine(Stop());
    }
    // Update is called once per frame
    void Update()
    {
        if (time != false)
        { 
            Vector3 dir = transform.right;
            rbd.MovePosition(transform.position + dir * speed * Time.deltaTime);
        }
        else
        {
            Vector3 dir = transform.right;
            rbd.MovePosition(transform.position - dir * speed * Time.deltaTime);
        }
    }
}
