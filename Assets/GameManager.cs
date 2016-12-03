using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool isPaused = false;
	public GameObject resume;
	public GameObject exit;
	public GameObject gameOver;
	public GameObject victoryScreen;

	public GameObject player;
	public GameObject boss;
	private PlayerStats ps;
	private BossOneStats bs;
	private int bossHp;
	private int playerHp;

	// Use this for initialization
	void Start () {
		ps = player.GetComponent<PlayerStats> ();
		bs = boss.GetComponent<BossOneStats> ();
		resume.SetActive (false);
		exit.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		bossHp = bs.health;
		playerHp = ps.getHealth ();
		if (bossHp <= 0) {
			// win
			victoryScreen.SetActive(true);
		}
		if (playerHp <= 0) {
			// lose
			gameOver.SetActive(true);
		}
			
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

	public void retry() {
		victoryScreen.SetActive (false);
		gameOver.SetActive (false);
		SceneManager.LoadScene (1);
	}
}
