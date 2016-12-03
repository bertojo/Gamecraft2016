using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour {

    private AudioSource AS;
    public AudioClip ac;
	// Use this for initialization
	void Start () {
        AS = GetComponent<AudioSource>();
        AS.clip = ac;
        AS.loop = true;
        AS.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
