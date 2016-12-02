using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float xMin, xMax, yMin, yMax;

    int speed = 0;
	// Update is called once per frame
	void Update () {


        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5;
        }
        else
        {
            speed = 10;
        }
        if(Input.GetKey("w"))
        {
            transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
        }
        if(Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, -speed, 0) * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }


		transform.position = new Vector3 (Mathf.Clamp (this.transform.position.x, xMin, xMax),
			Mathf.Clamp (this.transform.position.y, yMin, yMax), transform.position.z);
		
    }
}
