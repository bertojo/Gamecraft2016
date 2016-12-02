using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerShield : MonoBehaviour {

	public GameObject player;
	private GameObject shield;
	public GameObject shieldPrefab;
	public GameObject shieldReflectPrefab;
	private GameObject shieldReflect;
	private PlayerStats ps;

	private float shieldTimer;
	private int damageAbsorbed;

	void Start () {
		damageAbsorbed = 0;
		shieldTimer = 0.0f;
		ps = player.GetComponent<PlayerStats> ();
		shield = Instantiate (shieldPrefab, player.transform.position, Quaternion.identity);
		shield.SetActive (false);
	}

	void Update () {
		if (Input.GetKey (KeyCode.K) && ps.getEnergy() >= 50 && shieldTimer <= 0.0f) {
			shield.SetActive (true);
			shieldTimer = 4.0f;
		}

		if (shieldTimer > 0.0f) {
			shieldTimer -= Time.deltaTime;
		} else {
			if (shield.activeSelf) {
				shield.SetActive (false);
				if (damageAbsorbed > 0) {
					shieldReflect = Instantiate (shieldReflectPrefab, player.transform.position, Quaternion.identity);
					shieldReflect.gameObject.GetComponent<ShieldStats>().setDamage(damageAbsorbed);
				}
				damageAbsorbed = 0;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (shield.activeSelf) {
			if (col.gameObject.tag == "enemy_bullet") {
				damageAbsorbed += col.gameObject.GetComponent<EnemyBullet> ().damage;
				Destroy (col.gameObject);
			}
		}
	}
}
