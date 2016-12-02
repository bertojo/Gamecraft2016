using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollide : MonoBehaviour {

	private Rigidbody2D rb2d;
	private PlayerStats ps;

	void Start () {
		rb2d = this.gameObject.GetComponent<Rigidbody2D> ();
		ps = this.gameObject.GetComponent<PlayerStats> ();
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "enemy_bullet") {
			ps.increaseEnergy (1);
			ps.decreaseHealth (1);
			Destroy (col.gameObject);
		}
	}
}
