using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerHeal : MonoBehaviour {

	private PlayerStats ps;
	public float cooldown;
	private float origCooldown;

	// Use this for initialization
	void Start () {
		origCooldown = cooldown;
		ps = this.gameObject.GetComponent<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.J) && ps.getEnergy() >= 25 && cooldown <= 0.0f) {
			ps.increaseHealth (1);
			ps.decreaseEnergy (25);
			cooldown = origCooldown;
		}
		cooldown -= Time.deltaTime;
	}
}
