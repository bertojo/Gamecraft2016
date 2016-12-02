using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {

	public float despawnTimer = 3.0f;
	public float speed = 1.0f;
	private Rigidbody2D rb2d;
	private Vector3 direction;
	public int damage = 1;

	// Use this for initialization
	void Start () {
		rb2d = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (despawnTimer <= 0.0f) {
			Destroy (this.gameObject);
		}
		direction.Normalize();
		rb2d.MovePosition (this.transform.position + speed * direction * Time.deltaTime);

		despawnTimer -= Time.deltaTime;
	}

	public void setDir(Vector3 dir) {
		direction = dir;
	}
}
