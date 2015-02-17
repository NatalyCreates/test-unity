using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public Vector3 direction = Vector3.forward;
	//public float speed = 1.0f;
	public float speed = InitGlobals.moveForwardSpeed * (-1);

	// Use this for initialization
	void Start () {
		speed = InitGlobals.moveForwardSpeed * (-1);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.rotation * (direction.normalized * speed * Time.deltaTime);
	}
}
