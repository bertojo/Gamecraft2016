﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletsMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, 20, 0) * Time.deltaTime);

        //Remove this after adding to main game.
        if(transform.position.y >= 5)
        {
            Object.Destroy(this.gameObject);
        }
	}
}
