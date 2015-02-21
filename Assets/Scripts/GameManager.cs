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

	private bool hasSaved = false;

	// Use this for initialization
	void Start() {
		Instance = this;
		LoadHighScore();
	}
	
	// Update is called once per frame
	void Update() {

		if(GameObject.FindGameObjectWithTag("Player") == null) {
			gameOver = true;
		}
		if (gameOver) {
			if (!hasSaved) {
				SaveHighScore();
				hasSaved = true;
			}
			if(Input.anyKeyDown) {
				Application.LoadLevel(Application.loadedLevel);
			}
		}
		else { // game isn't over
			score += pointsPerUnitTravelled * gameSpeed * Time.deltaTime;
			if (score > highScore) {
				highScore = score;
			}
		}
	}

	void SaveHighScore() {
		PlayerPrefs.SetInt("HighScore", (int)highScore);
		PlayerPrefs.Save();
	}

	void LoadHighScore() {
		highScore = PlayerPrefs.GetInt("HighScore");
	}

	void OnGUI() {
		GUIStyle style = new GUIStyle();
		style.fontSize = 30;
		int currentScore = (int)score;
		int currentHighScore = (int)highScore;
		GUILayout.Label("Score: " + currentScore.ToString(), style);
		GUILayout.Label("High-Score: " + currentHighScore.ToString(), style);
		//GUILayout.Label(score.ToString());
		if (gameOver == true) {
			GUILayout.Label("Game Over! Press any key to reset!", style);
		}
	}
}
