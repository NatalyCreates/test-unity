using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager Instance;

	public float pointsPerUnitTravelled = 1.0f;

	private float score = 0.0f;

	public float gameSpeed = 30.0f;
	public float heroMoveSpeed = 20.0f;

	private bool gameOver = false;

	private static float highScore = 0.0f;

	// Use this for initialization
	void Start() {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update() {

		score += pointsPerUnitTravelled * gameSpeed * Time.deltaTime;
		if (score > highScore) {
			highScore = score;
		}

		if(GameObject.FindGameObjectWithTag("Player") == null) {
			gameOver = true;
		}
		if (gameOver) {
			if(Input.anyKeyDown) {
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}

	void OnGUI() {
		GUIStyle style = new GUIStyle();
		style.fontSize = 30;
		int currentScore = (int)score;
		GUILayout.Label("Score: " + currentScore.ToString(), style);
		//GUILayout.Label(score.ToString());
		if (gameOver == true) {
			GUILayout.Label("Game Over! Press any key to reset!", style);
		}
	}
}
