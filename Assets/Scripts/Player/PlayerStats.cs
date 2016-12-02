using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	public int health;
	public int energy;
    public int weaponUpgradeLevel;
	private GameObject player;
	private Animator anim;

	void Start () {
		player = this.gameObject;
		anim = player.GetComponent<Animator> ();
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
		if (energy < 100) {
			energy += value;
			energy = Mathf.Min (100, energy);
		}
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
		if (health <= 0) {
			anim.SetInteger ("state", 1);
		}
	}
}
