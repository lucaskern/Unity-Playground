using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Break : MonoBehaviour {

	public AudioSource player;

	public ParticleSystem burst;

	public GameObject gameMngr;
	private DrawUI counter;

	void Start()
	{
		counter = gameMngr.GetComponent<DrawUI> ();
	}

	void OnCollisionEnter(Collision col)
	{
		burst.transform.position = col.gameObject.transform.position;

		if (col.gameObject.tag == "breakable") 
		{
			burst.Play();
			player.Play();


			Destroy(col.gameObject);

			counter.points = counter.points + 1;
		}
	}

}
