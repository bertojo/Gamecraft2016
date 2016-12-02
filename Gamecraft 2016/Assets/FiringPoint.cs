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

	public int pattern = 1;

	// Use this for initialization
	void Start () {
		t = 0.0f;
		patternZeroCooldown = cooldown;
		patternOneCooldown = 1.0f;
		origCooldown = cooldown;
	}

	// Update is called once per frame
	void Update () {

		if (pattern == 0) {      // circular
			if (t > Mathf.PI * 2) {
				t = 0;
			}
			if (cooldown <= 0.0f) {
				GameObject bullet = Instantiate (bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
				bullet.gameObject.GetComponent<EnemyBullet>().setDir (new Vector3(r * Mathf.Cos(t), r * Mathf.Sin(t), 0));
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
			
				bullet1.gameObject.GetComponent<EnemyBullet>().setDir (new Vector3(Mathf.Cos(-Mathf.PI / 4.0f), Mathf.Sin(-Mathf.PI / 4.0f), 0));
				bullet2.gameObject.GetComponent<EnemyBullet>().setDir (new Vector3(Mathf.Cos(-Mathf.PI / 2.0f), Mathf.Sin(-Mathf.PI / 2.0f), 0));
				bullet3.gameObject.GetComponent<EnemyBullet>().setDir (new Vector3(Mathf.Cos(-Mathf.PI / 4.0f), Mathf.Sin(-Mathf.PI / 2.0f) - Mathf.Cos(-Mathf.PI / 4.0f), 0));
				cooldown = patternOneCooldown;
			}

			t += 0.1f;
			cooldown -= Time.deltaTime;
		}
	}
}
