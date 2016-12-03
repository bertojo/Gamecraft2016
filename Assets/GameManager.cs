using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool isPaused = false;
	public GameObject resume;
	public GameObject exit;

	// Use this for initialization
	void Start () {
		resume.SetActive (false);
		exit.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pauseButton() {
		isPaused = !isPaused;
		if (isPaused) {
			Time.timeScale = 0;
			resume.SetActive (true);
			exit.SetActive (true);

		} else { 
			Time.timeScale = 1;
			resume.SetActive (false);
			exit.SetActive (false);
		}
	}

	public void exitToMenu() {
		Time.timeScale = 1;
		resume.SetActive (false);
		exit.SetActive (false);
		SceneManager.LoadScene (0);
	}
}
