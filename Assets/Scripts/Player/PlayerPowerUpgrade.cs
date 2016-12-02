using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUpgrade : MonoBehaviour {

    private PlayerStats ps;
    private double cooldown;
    private bool onCD;
	// Use this for initialization
	void Start () {
		ps = this.gameObject.GetComponent<PlayerStats>();
        cooldown = 1;
        onCD = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (ps.health > 0) {
			if(Input.GetKey(KeyCode.L) && ps.getEnergy() >= 100)
	        {
	            ps.decreaseEnergy(100);
	            ps.increaseWeapon();
	        }
		}
	}
}
