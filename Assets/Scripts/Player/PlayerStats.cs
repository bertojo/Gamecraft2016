using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	public int health;
	public int energy;
    public int weaponUpgradeLevel;
	private GameObject player;

	void Start () {
		player = this.gameObject;
		health = 3;
		energy = 0;
        weaponUpgradeLevel = 1;
	}

    public void increaseWeapon()
    {
        if(weaponUpgradeLevel < 5)
        {
            weaponUpgradeLevel++;
        }
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

    public int getWeaponLevel()
    {
        return this.weaponUpgradeLevel;
    }
	void Update() {
		Debug.Log ("Player Health: " + health);
	}
}
