using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour {

	//public float speed = 1.0f;
	public float speed = InitGlobals.moveSidewaysSpeed * (-1);

	// Use this for initialization
	void Start () {
		speed = InitGlobals.moveSidewaysSpeed * (-1);
	}
	
	// Update is called once per frame
	void Update () {
		// Move the object according to player input and speed (per second)
		transform.position += Vector3.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime;
	}
}
