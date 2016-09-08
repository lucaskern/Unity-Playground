using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Break : MonoBehaviour {

	public AudioSource player;

	public ParticleSystem burst;

	void OnCollisionEnter(Collision col)
	{
		burst.transform.position = col.gameObject.transform.position;

		if (col.gameObject.tag == "breakable") 
		{
			burst.Play();
			player.Play();

			Destroy(col.gameObject);
		}
	}

}
