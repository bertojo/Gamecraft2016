using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManualAnimator : MonoBehaviour {

	public Sprite first;
	public Sprite second;
	private Image img;
	private float timer = 1.0f;

	// Use this for initialization
	void Start () {
		img = this.gameObject.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (timer <= 0) {
			if (img.sprite == first) {
				img.sprite = second;
			} else if (img.sprite == second) {
				img.sprite = first;
			}
			timer = 1.0f;
		}
		timer -= Time.deltaTime;
	}
}
