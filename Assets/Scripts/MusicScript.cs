using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour {


    public AudioSource AS;
    public AudioClip ac1, ac2, ac3;
    public BossOneStats bos;
    public PlayerStats ps;
	// Use this for initialization
	void Start () {
        AS = GetComponent<AudioSource>();
        AS.clip = ac1;
        AS.loop = true;
        AS.Play();
        GameObject player, boss;
        player = GameObject.Find("Player");
        ps = player.GetComponent<PlayerStats>();
        boss = GameObject.Find("Boss 1");
        bos = (BossOneStats)boss.GetComponent<BossOneStats>();
	}
	
	// Update is called once per frame
	void Update () {
		if(AS.clip == ac1)
        {
            if(bos.health <= 0)
            {
                AS.clip = ac2;
                AS.loop = false;
                AS.Play();
            }
            else if(ps.health <= 0)
            {
                AS.clip = ac3;
                AS.loop = false;
                AS.Play();
            }
        }
	}
}
