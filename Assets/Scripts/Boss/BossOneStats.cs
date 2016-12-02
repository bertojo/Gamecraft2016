using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossOneStats : MonoBehaviour {

	public int health;
	private ShieldStats ss;
	//private GameObject boss;

	// Use this for initialization
	void Start () {
		//boss = this.gameObject;
		health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "reflect_shield") {
			ss = col.gameObject.GetComponent<ShieldStats> ();
			this.health -= ss.getDamage ();
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == ("player_bullet")) {
			this.health--;
			Destroy (col.gameObject);
		}
	}
}
