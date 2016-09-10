using UnityEngine;
using System.Collections;

public class Filter : MonoBehaviour {

	//public int hp;

	public GameObject gameMngr;
	private DrawUI counter;
	private bool filtered = false;

	// Use this for initialization
	void Start () {

		//gameMngr = GameObject.Find ("GameManager");

		counter = gameMngr.GetComponent<DrawUI> ();
		Debug.Log ("filter set up");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col)
	{
		Debug.Log ("collision occured");
		if (col.gameObject.tag == "breakable") {
			counter.hp = counter.hp - 1;
			Destroy (col.gameObject);

			filtered = true;
		} else if (col.gameObject.tag == "breakable" && filtered == true) 
		{

		}
	}

}
