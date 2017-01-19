using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
	public Text text;
	private int currentHeighScore;
	private static HighScore instance;
	public GameObject heighScore;
	// Use this for initialization
	void Start () {
		instance = new HighScore ();
		instance.text = text;
		if (!PlayerPrefs.HasKey ("HighScore")) {
			instance.SetHighScore (0);
		} else {
			instance.SetHighScore (instance.GetHighScore ());
		}


		//instance.heighscore = heighscore;


	}

	// Update is called once per frame
	void Update () {

	}

	public static HighScore GetInstance() {
		return instance;
	}

	public int GetHighScore() {
		return PlayerPrefs.GetInt ("HighScore");
	}

	public void SetHighScore(int score) {
		//currentHeighScore = score;
		//Debug.Log("score :" + (score==true));
		PlayerPrefs.SetInt("HighScore", score);
		text.text = "Highscore:  " + score;
	}

	public void ResetHighScore() {
		PlayerPrefs.SetInt ("HighScore", 0);
		//currentHeighScore = 0;	
	}
}
