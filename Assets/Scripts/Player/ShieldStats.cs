using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldStats : MonoBehaviour {

	private int damage;

	void Start () {
		//damage = 0;
	}

	public void setDamage(int value) {
		damage = value;
	}

	public int getDamage() {
		return this.damage;
	}
}
