using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {

	public float despawnTimer = 3.0f;
	public float speed = 1.0f;
	private Rigidbody2D rb2d;
	private Vector3 direction;
	public int damage = 1;
	public bool isMarked = false;

	private BossOneStats bos;

	// Use this for initialization
	void Start () {
		rb2d = this.GetComponent<Rigidbody2D> ();
		bos = GameObject.Find ("Boss 1").GetComponent<BossOneStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (despawnTimer <= 0.0f) {
			Destroy (this.gameObject);
		}
		direction.Normalize();
		rb2d.MovePosition (this.transform.position + speed * direction * Time.deltaTime);

		despawnTimer -= Time.deltaTime;

		if (bos.isSpecialReady ()) {
			int randNum = Random.Range (0, 10);
			if (randNum <= 5)
				speed = -speed;
			else {
				if (this.transform.position.x < -4.8f)
					direction = new Vector3 (1, 0);
				else
					direction = new Vector3 (-1, 0);
			}
		}
	}

	public void setDir(Vector3 dir) {
		direction = dir;
	}
}
