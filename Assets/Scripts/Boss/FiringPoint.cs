using UnityEngine;
using System.Collections;

public class FiringPoint : MonoBehaviour {

	public float cooldown = 1.0f;
	private float patternZeroCooldown;
	private float patternOneCooldown;
	private float origCooldown;
	public GameObject bulletPrefab;
	private float t;
	private float r = 1.0f;

	private BossOneStats bos;
	private float bosLife;

	public int pattern = 0;

	private float changePatternTimer = 3.0f; 

	// Use this for initialization
	void Start () {
		t = 0.0f;
		patternZeroCooldown = cooldown;
		patternOneCooldown = 1.0f;
		origCooldown = cooldown;
		bos = this.GetComponentInParent<BossOneStats> ();
		bosLife = bos.health;
	}

	// Update is called once per frame
	void Update () {
		if (bos.health * 1.0f < bosLife * 0.2f)
			pattern = 6;
		else {
			if (changePatternTimer <= 0.0f) {
				changePatternTimer = 10.0f;
				pattern++;
				if (pattern == 6)
					pattern = 0;
			} else {
				changePatternTimer -= Time.deltaTime;
			}
		}

		if (pattern == 0) {      // circular
			if (t > Mathf.PI) {
				t = 0;
			}
			if (cooldown <= 0.0f) {
				GameObject bullet = Instantiate (bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
				bullet.gameObject.GetComponent<EnemyBullet> ().setDir (new Vector3 (r * Mathf.Cos (-t), r * Mathf.Sin (-t), 0));
				cooldown = origCooldown;
			}

			t += 0.1f;
			cooldown -= Time.deltaTime;
		} else if (pattern == 1) {    // spread
			if (t > Mathf.PI * 2) {
				t = 0;
			}
			if (cooldown <= 0.0f) {
				GameObject bullet1 = Instantiate (bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
				GameObject bullet2 = Instantiate (bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
				GameObject bullet3 = Instantiate (bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
			
				bullet1.gameObject.GetComponent<EnemyBullet> ().setDir (new Vector3 (Mathf.Cos (-Mathf.PI / 1.8f), Mathf.Sin (-Mathf.PI / 1.8f), 0));
				bullet2.gameObject.GetComponent<EnemyBullet> ().setDir (new Vector3 (Mathf.Cos (-Mathf.PI / 1.98f), Mathf.Sin (-Mathf.PI / 1.98f), 0));
				bullet3.gameObject.GetComponent<EnemyBullet> ().setDir (new Vector3 (Mathf.Cos (-Mathf.PI / 2.2f), Mathf.Sin (-Mathf.PI / 2.2f), 0));
				cooldown = patternOneCooldown;
			}

			t += 0.1f;
			cooldown -= Time.deltaTime;
		} else if (pattern == 2) { // opposite circular
			float halfpi = Mathf.PI / 2.0f;
			if (t > Mathf.PI)
				t = 0;

			if (cooldown <= 0.0f) {
				GameObject bullet = Instantiate (bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
				bullet.gameObject.GetComponent<EnemyBullet> ().setDir (new Vector3 (r * Mathf.Sin (-t - halfpi), r * Mathf.Cos (-t - halfpi), 0));
				cooldown = origCooldown;
			}
			t += 0.1f;
			cooldown -= Time.deltaTime;
		} else if (pattern == 3) { //zig-zag

			if (cooldown <= 0.0f) {
				GameObject bullet = Instantiate (bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
				bullet.gameObject.GetComponent<EnemyBullet> ().setDir (new Vector3 (0, -1, 0));
				cooldown = origCooldown;
			}
			cooldown -= Time.deltaTime;
		} else if (pattern == 4) { //quadratic pattern to right
			if (t > Mathf.PI * 5.0f / 6)
				t = Mathf.PI * 1.0f / 7;

			if (cooldown <= 0.0f) {
				GameObject bullet = Instantiate (bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
				bullet.gameObject.GetComponent<EnemyBullet> ().setDir (new Vector3 (r * t, -r * t * t, 0));
				cooldown = origCooldown;
			}
			t += 0.1f;
			cooldown -= Time.deltaTime;
		} else if (pattern == 5) {
			if (t > Mathf.PI * 5.0f / 6)
				t = Mathf.PI * 1.0f / 7;

			if (cooldown <= 0.0f) {
				GameObject bullet = Instantiate (bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
				bullet.gameObject.GetComponent<EnemyBullet> ().setDir (new Vector3 (-r * t, -r * t * t, 0));
				cooldown = origCooldown;
			}
			t += 0.1f;
			cooldown -= Time.deltaTime;
		} else if (pattern == 6) { // impossibru pattern
			if (t > Mathf.PI * 5.0f / 6)
				t = Mathf.PI * 1.0f / 7;

			if (cooldown <= 0.0f) {
				GameObject bullet = Instantiate (bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
				float halfpi = Mathf.PI / 2.0f;
				bullet.gameObject.GetComponent<EnemyBullet> ().setDir (new Vector3 (r * Mathf.Pow(Mathf.Sin(t+halfpi), 3.0f), r * Mathf.Cos(t+halfpi), 0));
				cooldown = origCooldown;
			}
			t += 0.1f;
			cooldown -= Time.deltaTime;
		} 
	}
}
