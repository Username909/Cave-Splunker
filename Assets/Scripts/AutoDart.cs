﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script handles the auto instantiation of darts from the dart spawner
// every 2 seconds darts automatically spawn
public class AutoDart : MonoBehaviour {
    public GameObject Dart;
    public Transform Spawner;
    public float ShootTime = 2.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ShootTime -= Time.deltaTime;
        if (ShootTime < 0)
        {
            Instantiate(Dart, Spawner.position, Spawner.rotation);
            ShootTime = 2.0f;
        }
    }
}
