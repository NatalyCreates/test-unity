using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour {

	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		// Set speed to 5
		speed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		// Move the object according to player input and speed (per second)
		transform.position += Vector3.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime;
	}
}
