using UnityEngine;
using System.Collections;

public class ScaleOverTime : MonoBehaviour {

	public Vector3 initialScale = Vector3.zero;
	public Vector3 finalScale = Vector3.zero;

	public float time = 1.0f;

	// Use this for initialization
	void Start () {
		//initialScale.x = 1.5;
		//initialScale.y = 0;
		//initialScale.z = 1.5;
		//finalScale.x = 2;
		//finalScale.y = 10;
		//finalScale.z = 2;
		StartCoroutine("Scale");
	}

	IEnumerator Scale() {
		float t = 0.0f;

		while (t <= time) {
			// Linear interpolation
			transform.localScale = Vector3.Lerp(initialScale, finalScale, t/time);
			t += Time.deltaTime;
			yield return null;
		}
		transform.localScale = finalScale;
	}
}
