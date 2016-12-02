using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour {
    public double timer;
    public GameObject bulletPrefab1, bulletPrefab2;
    bool eitherOr;
	// Use this for initialization
	void Start () {
        timer = 0.1;
        eitherOr = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(timer <= 0)
        {
            if(eitherOr)
            {
                Instantiate(bulletPrefab1, (this.transform.position), Quaternion.identity);
                eitherOr = false;
            }
            else
            {
                Instantiate(bulletPrefab2, (this.transform.position), Quaternion.identity);
                eitherOr = true;
            }
            
            timer = 0.1;
        }
        timer -= Time.deltaTime;
	}
}
