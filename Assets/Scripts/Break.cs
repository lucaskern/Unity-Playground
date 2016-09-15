using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Break : MonoBehaviour {

	public AudioSource player;

	public GameObject gameMngr;

	private DrawUI counter;

	//public GameObject enemyInstance;
	//public GameObject burst;

	void Start()
	{
		counter = gameMngr.GetComponent<DrawUI> ();
	}

	void OnCollisionEnter(Collision col)
	{

		if (col.gameObject.tag == "breakable") {
			//burst.SetActive(true);

			player.Play ();
			Destroy (col.gameObject);
			counter.points = counter.points + 1;
		} else if (col.gameObject.tag == "powerup_Ammo") 
		{
			Destroy(col.gameObject);
			counter.ammo += 50;
		}
	}

//	ParticleSystem GetParticleSystem(Collision objectInstance)
//	{
//		enemyInstance = objectInstance.gameObject;
//		burst = enemyInstance.GetComponentInChildren<ParticleSystem> ();
//
//		if (burst != null) {
//			return burst;
//		} else if (burst == null) {
//			Debug.Log("NO PARTICLE SYSTEM");
//			return null;
//		}
//
//		return null;
//	}

}
