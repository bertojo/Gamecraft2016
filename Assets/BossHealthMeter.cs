using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthMeter : MonoBehaviour {

	public GameObject meterFill;

	public GameObject boss;
	private BossOneStats bs;
	private int health;
	private float perc;

	// Use this for initialization
	void Start () {
		bs = boss.GetComponent<BossOneStats> ();
	}

	// Update is called once per frame
	void Update () {
		health = bs.health;
		health = Mathf.Max (0, health);
		perc = (float)health / (float)bs.getMaxHp();
		//Debug.Log ("PERC: " + perc);
		Vector3 scale = new Vector3(1, perc, 1);
		meterFill.transform.localScale = scale;
	}
}
