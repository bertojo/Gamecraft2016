using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour {

	public GameObject heart1;
	public GameObject heart2;
	public GameObject heart3;

	public GameObject player;
	private PlayerStats ps;
	private int health;
	private Vector4 blackedOut;
	private Vector4 normal;


	// Use this for initialization
	void Start () {
		blackedOut = new Vector4 (0, 0, 0, 255);
		normal = new Vector4 (255, 255, 255, 255);
		ps = player.GetComponent<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		health = ps.getHealth ();
		if (health == 3) {
			heart1.GetComponent<Image> ().color = normal;
			heart2.GetComponent<Image> ().color = normal;
			heart3.GetComponent<Image> ().color = normal;
		} else if (health == 2) {
			heart1.GetComponent<Image> ().color = normal;
			heart2.GetComponent<Image> ().color = normal;
			heart3.GetComponent<Image> ().color = blackedOut;
		} else if (health == 1) {
			heart1.GetComponent<Image> ().color = normal;
			heart2.GetComponent<Image> ().color = blackedOut;
			heart3.GetComponent<Image> ().color = blackedOut;
		} else if (health == 0) {
			heart1.GetComponent<Image> ().color = blackedOut;
			heart2.GetComponent<Image> ().color = blackedOut;
			heart3.GetComponent<Image> ().color = blackedOut;
		}
			
	}
}
