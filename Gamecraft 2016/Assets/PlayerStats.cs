using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	public int health;
	private int energy;
	public GameObject player;

	void Start () {
		health = 3;
		energy = 0;
	}

	public void increaseEnergy(int value) {
		energy += value;
	}

	public void decreaseEnergy(int value) {
		energy -= value;
	}

	public void increaseHealth(int value) {
		health += value;
	}

	public void decreaseHealth(int value) {
		health -= value;
	}

	public int getHealth() {
		return this.health;
	}

	public int getEnergy() {
		return this.energy;
	}
}
