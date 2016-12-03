using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerHeal : MonoBehaviour {

	private PlayerStats ps;
	public float cooldown;
	private float origCooldown;
    private AudioSource AS;
    public AudioClip ac;
	public GameObject animObject;

	// Use this for initialization
	void Start () {
		origCooldown = cooldown;
		ps = this.gameObject.GetComponent<PlayerStats> ();
        AS = GetComponent<AudioSource>();
        AS.clip = ac;
	}
	
	// Update is called once per frame
	void Update () {
		if (ps.health > 0 && ps.health < 3) {
			if (Input.GetKey (KeyCode.J) && ps.getEnergy() >= 25 && cooldown <= 0.0f) {
                AS.clip = ac;
                AS.Play();
				ps.increaseHealth (1);
				ps.decreaseEnergy (25);
				cooldown = origCooldown;
				animObject.SetActive (true);
			}
		}
		cooldown -= Time.deltaTime;
	}
}
