using UnityEngine;
using System.Collections;

public class PseudoMoveLeftAndRight : MonoBehaviour {

	public Vector2 vec = Vector2.right;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Renderer>().material.mainTextureOffset += vec *
			(GameManager.Instance.heroMoveSpeed / 10) * Input.GetAxis("Horizontal") * Time.deltaTime;
	}
}
