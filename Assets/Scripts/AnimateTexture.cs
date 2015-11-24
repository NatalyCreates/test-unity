using UnityEngine;
using System.Collections;

public class AnimateTexture : MonoBehaviour {

	public Vector2 vec = Vector2.up;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Renderer>().material.mainTextureOffset += vec *
			(GameManager.Instance.gameSpeed / 10) * Time.deltaTime;
	}
}
