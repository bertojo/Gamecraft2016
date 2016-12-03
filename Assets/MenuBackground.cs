using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuBackground : MonoBehaviour {

	public Sprite first;
	public Sprite second;
	public Sprite third;
	private Image img;
	private float timer;

	// Use this for initialization
	void Start () {
		timer = 3.0f;
		img = this.gameObject.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > 2.5f && timer <= 3.0f) {
			img.sprite = first;
		} else if (timer > 2.0f && timer <= 2.5f) {
			img.sprite = second;
		} else if (timer > 1.5f && timer <= 2.0f) {
			img.sprite = third;
		} else if (timer > 1.0f && timer <= 1.5f) {
			img.sprite = second;
		} else if (timer > 0.0f && timer <= 1.0f) {
			img.sprite = first;
		} else {
			timer = 3.0f;
		}
		timer -= Time.deltaTime;
	}
}
