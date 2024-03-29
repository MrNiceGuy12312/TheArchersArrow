﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    Rigidbody2D rb;

    bool hashit;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(hashit == false)
        {
            trackMovement();
        }
      
    }

    void trackMovement()
    {
        Vector2 direction = rb.velocity;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

   void OnCollisionEnter2D(Collision2D collision)
    {
        //if the arrow hits the target
        hashit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
    }
}
