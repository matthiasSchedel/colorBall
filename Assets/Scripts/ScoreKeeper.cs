using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
	
	private int score;
	public Text text;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("LastScore", 0);
		score = 0;
		text.text = "Score: " + score.ToString ();
		//text = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UpdateScore() {
		score += 10;
		text.text = "Score: " + score.ToString ();
		PlayerPrefs.SetInt ("LastScore", score);
		if (score > HighScore.GetInstance().GetHighScore()) {
			HighScore.GetInstance().SetHighScore (score);
		}


	}
}
