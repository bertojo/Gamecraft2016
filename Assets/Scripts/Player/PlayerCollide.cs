using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollide : MonoBehaviour {

	//private Rigidbody2D rb2d;
	private PlayerStats ps;
    public bool notInvul, alphaIncDec;
    public double invulTimer;
    private SpriteRenderer sr;
    private Color color;

	void Start () {
		//rb2d = this.gameObject.GetComponent<Rigidbody2D> ();
		ps = this.gameObject.GetComponent<PlayerStats> ();
        sr = this.gameObject.GetComponent<SpriteRenderer>();
        color = sr.color;
        notInvul = true;
        alphaIncDec = true;
        invulTimer = 0;
	}

    void Update ()
    {
        if(!notInvul)
        {
            invulTimer -= Time.deltaTime;
            if(sr.enabled)
            {
                sr.enabled = !sr.enabled;
            }
            else
            {
                sr.enabled = !sr.enabled;
            }

            if (invulTimer <= 0)
            {
                notInvul = !notInvul;
                sr.enabled = true;
            }
            
        }
    }
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "enemy_bullet") {
			//ps.decreaseEnergy (4);
            if(notInvul)
            {
                notInvul = !notInvul;
                ps.decreaseHealth(1);
                invulTimer = 2;
                Destroy(col.gameObject);
            }
		}
	}
}
