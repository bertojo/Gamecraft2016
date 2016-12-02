using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private bool isPaused = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pauseButton() {
		isPaused = !isPaused;
		if (isPaused) {
			Time.timeScale = 0;
		} else { 
			Time.timeScale = 1;
		}

	}
}
