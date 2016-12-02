using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour {
    public double timer;
    public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
        timer = 0.1;
	}
	
	// Update is called once per frame
	void Update () {
		if(timer <= 0)
        {
 	       Instantiate(bulletPrefab, (this.transform.position), Quaternion.identity);            
            timer = 0.1;
        }
        timer -= Time.deltaTime;
	}
}
