using UnityEngine;
using System.Collections;
using System.Timers;

public class Enemy : MonoBehaviour {

	GameObject enemyInstance;

	// Use this for initialization
	void Start () {
		enemyInstance = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
			MoveEnemy ();
	}

	void MoveEnemy()
	{
		if (Time.time % 3 < .1 && Time.time > 1) 
		{
			enemyInstance.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 3);
			//MoveEnemy ();

			Debug.Log("Enemy moved forward!");
		}
		Debug.Log ("MoveEnemy called at " + Time.time);
	}
}
