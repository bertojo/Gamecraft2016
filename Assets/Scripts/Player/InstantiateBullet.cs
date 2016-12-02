using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour {
    public double timer;
    public GameObject bulletPrefab;
    private PlayerStats ps;

	// Use this for initialization
	void Start () {
<<<<<<< HEAD
        timer = 0.1;
        ps = this.gameObject.GetComponent<PlayerStats>();
    }
=======
        timer = 0.2;
	}
>>>>>>> 280a9cc3ecd3a0b318ed6b1551414a4bf72979fd
	
	// Update is called once per frame
	void Update () {
		if(timer <= 0)
        {
<<<<<<< HEAD
            if(ps.getWeaponLevel() == 1)
            {
                Instantiate(bulletPrefab, (this.transform.position), Quaternion.identity);
            }
            else if(ps.getWeaponLevel() == 2)
            {
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(-0.1f, 0, 0), Quaternion.identity);
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(0.1f, 0, 0), Quaternion.identity);
            }
            else if (ps.getWeaponLevel() == 3)
            {
                Instantiate(bulletPrefab, (this.transform.position), Quaternion.identity);
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(-0.2f, 0, 0), Quaternion.identity);
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(0.2f, 0, 0), Quaternion.identity);
            }
            else if (ps.getWeaponLevel() == 4)
            {
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(-0.1f, 0, 0), Quaternion.identity);
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(0.1f, 0, 0), Quaternion.identity);
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(-0.3f, 0, 0), Quaternion.identity);
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(0.3f, 0, 0), Quaternion.identity);
            }
            else if (ps.getWeaponLevel() == 5)
            {
                Instantiate(bulletPrefab, (this.transform.position), Quaternion.identity);
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(-0.2f, 0, 0), Quaternion.identity);
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(0.2f, 0, 0), Quaternion.identity);
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(-0.4f, 0, 0), Quaternion.identity);
                Instantiate(bulletPrefab, (this.transform.position) + new Vector3(0.4f, 0, 0), Quaternion.identity);
            }
            timer = 0.1;
=======
 	       Instantiate(bulletPrefab, (this.transform.position), Quaternion.identity);            
            timer = 0.2;
>>>>>>> 280a9cc3ecd3a0b318ed6b1551414a4bf72979fd
        }
        timer -= Time.deltaTime;
	}
}
