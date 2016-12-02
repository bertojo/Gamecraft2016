using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldReflect : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		speed = 1.5f;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);

		if (this.transform.position.y >= 5) {
			Destroy (this.gameObject);
		}
	}
}
