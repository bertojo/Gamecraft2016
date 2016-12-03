using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossOneStats : MonoBehaviour {

	public int health;
	private float maxHp;
	private ShieldStats ss;
	private Animator anim;
	public GameObject player;

	private bool specialPower;
	private float specialPowerTimer;

	void Start () {
		maxHp = (float)health;
		anim = this.GetComponent<Animator>();
		specialPowerTimer = 10.0f;
	}

	void Update () {
		if (health <= 0) {
			anim.SetInteger ("state", 1);
		}

		if (specialPowerTimer <= 0.0f) {
			specialPower = true;
			specialPowerTimer = 10.0f;
		} else {
			specialPower = false;
			specialPowerTimer -= Time.deltaTime;
		}
	}

	public float getMaxHp() {
		return maxHp;
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

	public void destroyThis() {
		Destroy (this.gameObject);
	}

	public void disarm() {
		Destroy (this.transform.GetChild(0).gameObject);
		Destroy (this.transform.GetChild(1).gameObject);
		Destroy (this.transform.GetChild(2).gameObject);
	}

	public void win() {
		player.GetComponent<Animator> ().SetInteger ("state", 2);
	}

	public bool isSpecialReady() {
		return this.specialPower;
	}
}
