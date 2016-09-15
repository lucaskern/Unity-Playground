using UnityEngine;
using System.Collections;
using System.Timers;

public class Enemy : MonoBehaviour {

	private GameObject enemyInstance;

	public GameObject burst;

	// Use this for initialization
	void Start () {
		enemyInstance = this.gameObject;

		InvokeRepeating ("MoveEnemy", 3.0f, 3.0f);
	}

	// Update is called once per frame
	void Update () 
	{
	}

	void MoveEnemy()
	{
			enemyInstance.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 3);
			//Debug.Log("Enemy moved forward!");
	}

//	void OnDestroy()
//	{
//		burst.SetActive (true);
//	}
}
