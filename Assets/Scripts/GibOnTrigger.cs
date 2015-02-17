using UnityEngine;
using System.Collections;

public class GibOnTrigger : MonoBehaviour {

	public GameObject gib;

	void OnTriggerEnter() {
		// Debug.Log ("Shot the enemy!");
		Instantiate(gib, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}
