using UnityEngine;
using System.Collections;
using System.Timers;

public class FireBall : MonoBehaviour {

	public Rigidbody ballPrefab;
	public Transform fixPos;

	int ammo = 1000;

	float timer = 1;

	public AudioClip[] audioClip;

	public GameObject gameMngr;
	private DrawUI counter;


	// Use this for initialization
	void Start () {
		counter = gameMngr.GetComponent<DrawUI> ();
	}
	
	// Update is called once per frame
	void Update () {

		//Timer count down and ammo replenish
		timer -= Time.deltaTime;
		if (timer < 0) {
			ammo = ammo + 2;
			timer = 1;
			//Debug.Log(ammo + "ammo left!");
		}

		//Fires big or small projectile
		if (Input.GetButtonDown ("Fire1") && ammo >= 2) {
			//generate random force
			int randomForce = Random.Range (2200, 2900);

			//generate projectile
			Rigidbody ballInstance;
			ballInstance = Instantiate (ballPrefab, fixPos.position, fixPos.rotation) as Rigidbody;
			ballInstance.AddForce (fixPos.forward * randomForce);

			PlaySound(0);

			//decrease ammo count
			ammo = ammo - 2;
			counter.ammo = counter.ammo - 2;
			//Debug.Log(ammo + "ammo left!");

		} else if (Input.GetButtonDown ("Fire2") && ammo >= 10) {
			//generate random force
			int randomForce = Random.Range(2500,4000);

			//create projectile
			Rigidbody ballInstance;
			ballInstance = Instantiate (ballPrefab, fixPos.position, fixPos.rotation) as Rigidbody;
			ballInstance.transform.localScale += new Vector3(4.0F,4.0F,4.0F);
			ballInstance.AddForce (fixPos.forward * randomForce);

			//play sound
			PlaySound (1);

			//decrease ammo count
			ammo = ammo - 10;
			counter.ammo = counter.ammo - 10;
			//Debug.Log(ammo + "ammo left!");
		}

	}

	//Plays sounds from an array of clips
	void PlaySound(int clip) 
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.volume = 0.2f;
		audio.clip = audioClip[clip];
		audio.Play ();
	}
}
