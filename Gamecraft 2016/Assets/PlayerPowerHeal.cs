using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerHeal : MonoBehaviour {

	private PlayerStats ps;

	// Use this for initialization
	void Start () {
		ps = this.gameObject.GetComponent<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.J) && ps.getEnergy() >= 25) {
			ps.increaseHealth (1);
			ps.decreaseEnergy (25);
		}
	}
}
