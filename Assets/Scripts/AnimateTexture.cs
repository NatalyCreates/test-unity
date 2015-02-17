using UnityEngine;
using System.Collections;

public class AnimateTexture : MonoBehaviour {

	public Vector2 vec = Vector2.up;
	//public float speed = 1.0f;
	public float speed = InitGlobals.moveForwardSpeed / 10;

	// Use this for initialization
	void Start () {
		speed = InitGlobals.moveForwardSpeed / 10;
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.mainTextureOffset += vec * speed * Time.deltaTime;
	}
}
