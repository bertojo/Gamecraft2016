using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCloseCollide : MonoBehaviour {

	private PlayerStats ps;

	// Use this for initialization
	void Start () {
		ps = this.GetComponentInParent<PlayerStats> ();
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "enemy_bullet" && col.gameObject.GetComponent<EnemyBullet> ().isMarked == false) {
			ps.increaseEnergy (4);
			col.gameObject.GetComponent<EnemyBullet> ().isMarked = true;
		}
	}
}
