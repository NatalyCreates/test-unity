using UnityEngine;
using System.Collections;

public class MoveWorldToHero : MonoBehaviour {

	public Vector3 direction = Vector3.forward * (-1);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.rotation *
			(direction.normalized * GameManager.Instance.gameSpeed * Time.deltaTime);
	}
}
