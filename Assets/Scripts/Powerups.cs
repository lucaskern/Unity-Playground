using UnityEngine;
using System.Collections;

public class Powerups : MonoBehaviour {
	
	//public GameObject pellet;
	//public Transform fixPos;

	public GameObject gameMngr;
	private DrawUI counter;

	public AudioClip[] audioClip;

	// Use this for initialization
	void Start () {
		counter = gameMngr.GetComponent<DrawUI> ();
	}

	void OnCollisionEnter(Collision col) 
	{
		if (col.gameObject.tag == "projectile") 
		{
			counter.ammo = counter.ammo + 50;
			PlaySound(0);
			Destroy(this.gameObject);
		}
	}

	void PlaySound(int clip) 
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.volume = 0.2f;
		audio.clip = audioClip[clip];
		audio.Play ();
	}


}
