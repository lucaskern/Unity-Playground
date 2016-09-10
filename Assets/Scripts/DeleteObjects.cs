using UnityEngine;
using System.Collections;

public class DeleteObjects : MonoBehaviour {

	//public Rigidbody projectile;

	void OnCollisionEnter (Collision col) {
		Destroy (col.gameObject);
	}
}
