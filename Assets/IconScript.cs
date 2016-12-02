using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconScript : MonoBehaviour {

	public GameObject player;
	private PlayerStats ps;
	public Sprite dulled;
	public Sprite normal;
	public float activationLevel;
	private int energy;

	// Use this for initialization
	void Start () {
		ps = player.GetComponent<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		energy = ps.getEnergy ();
		if (energy >= activationLevel) {
			this.GetComponent<Image> ().sprite = normal;
		} else {
			this.GetComponent<Image> ().sprite = dulled;
		}
	}
}
