﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        PlayerManager.health -= 5;
        Destroy(this.gameObject);
    }



    // Update is called once per frame
    void Update () {
		
	}
}
