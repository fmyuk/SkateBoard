﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skebo : MonoBehaviour {

    float speed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.speed = 0.1f;
        }

        transform.Translate(this.speed, 0, 0);

        this.speed *= 0.98f;
    }
}
