using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCloseCollide : MonoBehaviour {

	private PlayerStats ps;
	public GameObject player;

	// Use this for initialization
	void Start () {
		ps = player.gameObject.GetComponent<PlayerStats> ();
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "enemy_bullet")
			ps.increaseEnergy (5);
	}
}
