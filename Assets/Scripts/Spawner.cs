using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject spawnObject;

	public Transform spawnerPos;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", 1.0f, 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Spawn() 
	{
		GameObject objectInstance;

		objectInstance = Instantiate (spawnObject, spawnerPos.position, spawnerPos.rotation) as GameObject;
	}

}
