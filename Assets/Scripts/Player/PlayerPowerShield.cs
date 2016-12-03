using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerShield : MonoBehaviour {

	private GameObject player;
	private GameObject shield;
	//public GameObject shieldPrefab;
	public GameObject shieldReflectPrefab;
	private GameObject shieldReflect;
	private PlayerStats ps;

	public float shieldTimer;
	private int damageAbsorbed;

	private CircleCollider2D coll;
	private SpriteRenderer sr;
    private AudioSource AS;
    public AudioClip ac1, ac2;

	void Start () {
		player = this.transform.parent.gameObject;
		damageAbsorbed = 0;
		shieldTimer = 0.0f;
		ps = player.GetComponent<PlayerStats> ();
		//shield = Instantiate (shieldPrefab, player.transform.position, Quaternion.identity) as GameObject;
		shield = this.gameObject;
		sr = this.GetComponent<SpriteRenderer> ();
		coll = this.GetComponent<CircleCollider2D> ();

		sr.enabled = false;
		coll.enabled = false;

        AS = GetComponent<AudioSource>();
		//shield.SetActive (false);
	}

	void Update () {
		if (ps.health > 0) {
			if (Input.GetKey (KeyCode.K) && ps.getEnergy() >= 66 && shieldTimer <= 0.0f) {
                //shield.SetActive (true);
                sr.enabled = true;
				coll.enabled = true;
				shieldTimer = 4.0f;
				ps.decreaseEnergy (66);
                AS.clip = ac1;
                AS.Play();
            }

			if (shieldTimer > 0.0f) {
				shieldTimer -= Time.deltaTime;
			} else {
				if (shield.activeSelf) {
					//shield.SetActive (false);
					sr.enabled = false;
					coll.enabled = false;
					if (damageAbsorbed > 0) {
						shieldReflect = Instantiate (shieldReflectPrefab, player.transform.position, Quaternion.identity) as GameObject;
						shieldReflect.gameObject.GetComponent<ShieldStats>().setDamage(damageAbsorbed);
					}
					damageAbsorbed = 0;
				}
			}
			shield.transform.position = player.transform.position;
		}
	}

	void OnTriggerEnter2D(Collider2D col) {

		if (shield.activeInHierarchy) {
			if (col.gameObject.tag == "enemy_bullet") {
				damageAbsorbed += col.gameObject.GetComponent<EnemyBullet> ().damage;
				Destroy (col.gameObject);
                AS.clip = ac2;
                AS.Play();
            }
		}
	}
}
