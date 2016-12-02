using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyMeterScript : MonoBehaviour {

	public GameObject meterFill;

	public GameObject player;
	private PlayerStats ps;
	private int energy;
	private float perc;

	// Use this for initialization
	void Start () {
		ps = player.GetComponent<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		energy = ps.getEnergy ();
		perc = energy / 100.0f;

		Vector3 scale = new Vector3(1, perc, 1);
		meterFill.transform.localScale = scale;

	}
}
