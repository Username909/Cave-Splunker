﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//makes the boulder spin in a random rotation
public class RandomRotator : MonoBehaviour {

    public float tumble;

    private Rigidbody2D rBody; 

	// Use this for initialization
	void Start () {
        rBody = GetComponent<Rigidbody2D>();
        rBody.angularVelocity = Random.value * tumble;
	}
}
