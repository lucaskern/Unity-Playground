using UnityEngine;
using System.Collections;

public class DrawUI : MonoBehaviour {
	
	public int hp = 100;
	public int points = 0;
	public int ammo = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI ()
	{
		GUI.Box (new Rect (0,0,80,50), "HP:" + hp.ToString());
		GUI.Box (new Rect (0,80,80,50), "Score:" + points.ToString());
		GUI.Box (new Rect (0,160,80,50), "Ammo:" + ammo.ToString());
		//Debug.Log("score updated");
	}
}
