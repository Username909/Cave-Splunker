﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderTrap : MonoBehaviour {
    public GameObject Dart;
    public Transform Spawner;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D Col)
    {
        Instantiate(Dart, Spawner.position, Spawner.rotation);
    }
}
