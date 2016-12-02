using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossOneStats : MonoBehaviour {

	public int health;
	private ShieldStats ss;

	// Use this for initialization
	void Start () {
		health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "reflect_shield") {
			ss = col.gameObject.GetComponent<ShieldStats> ();
			health -= ss.getDamage ();
			Destroy (col.gameObject);
		}
	}
}
