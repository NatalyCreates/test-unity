﻿using UnityEngine;
using System.Collections;

public class AnimateTexture : MonoBehaviour {

	public Vector2 vec = Vector2.up;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.mainTextureOffset += vec * speed * Time.deltaTime;
	}
}