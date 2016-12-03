using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUpgrade : MonoBehaviour {

    private PlayerStats ps;
    private double cooldown;
    private bool onCD;
    private AudioSource AS;
    public AudioClip ac;

	// Use this for initialization
	void Start () {
		ps = this.gameObject.GetComponent<PlayerStats>();
        cooldown = 1;
        onCD = false;
        AS = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		if (ps.health > 0) {
			if(Input.GetKey(KeyCode.L) && ps.getEnergy() >= 100)
	        {
                AS.clip = ac;
                AS.Play();
	            ps.decreaseEnergy(100);
	            ps.increaseWeapon();
	        }
		}
	}
}
