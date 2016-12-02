using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour {

	public bool goingLeft = true;
	private GameObject boss;
	public float xMin;
	public float xMax;
	public float speed;

	// Use this for initialization
	void Start () {
		boss = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {

		if (boss.transform.position.x <= xMin) {
			goingLeft = false;
		}
		if (boss.transform.position.x >= xMax) {
			goingLeft = true;
		}

		if (goingLeft) {
			Vector3 newPos = new Vector3 (boss.transform.position.x - speed, boss.transform.position.y, boss.transform.position.z);
			boss.transform.position = newPos;
		} else {
			Vector3 newPos = new Vector3 (boss.transform.position.x + speed, boss.transform.position.y, boss.transform.position.z);
			boss.transform.position = newPos;
		}
	}
}
