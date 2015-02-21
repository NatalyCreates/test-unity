using UnityEngine;
using System.Collections;

public class MoveWorldOppositeHero : MonoBehaviour {

	public Vector3 direction = Vector3.right * (-1);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Move the object according to player input and speed (per second)
		transform.position += direction * GameManager.Instance.heroMoveSpeed *
			Input.GetAxis("Horizontal") * Time.deltaTime;
	}
}
