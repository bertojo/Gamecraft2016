﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private PlayerStats ps;
	public float xMin, xMax, yMin, yMax;

    float speed = 0;

	void Start() {
		ps = this.gameObject.GetComponent<PlayerStats> ();
	}

	// Update is called once per frame
	void Update () {

		if (ps.health > 0) {
			
			if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
				speed = 2.5f;
			} else {
				speed = 5f;
			}
			if (Input.GetKey ("w")) {
				transform.Translate (new Vector3 (0, speed, 0) * Time.deltaTime);
			}
			if (Input.GetKey ("s")) {
				transform.Translate (new Vector3 (0, -speed, 0) * Time.deltaTime);
			}
			if (Input.GetKey ("a")) {
				transform.Translate (new Vector3 (-speed, 0, 0) * Time.deltaTime);
			}
			if (Input.GetKey ("d")) {
				transform.Translate (new Vector3 (speed, 0, 0) * Time.deltaTime);
			}


			transform.position = new Vector3 (Mathf.Clamp (this.transform.position.x, xMin, xMax),
				Mathf.Clamp (this.transform.position.y, yMin, yMax), transform.position.z);
		}
		
    }
}
