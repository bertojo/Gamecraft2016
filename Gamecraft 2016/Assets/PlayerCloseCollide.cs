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

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "enemy_bullet")
			ps.increaseEnergy (5);
	}
}
