﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowDirection : MonoBehaviour
{

    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 bowPos = transform.position;

        direction = MousePos - bowPos; // calcuating the direction of which the bow faces

        faceMouse();
    }
    void faceMouse()
    {
        transform.right = direction;
    }
}
