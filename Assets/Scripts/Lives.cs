using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lives : MonoBehaviour {
	private static Lives instance;
	public Text text;
	private int lives;
	// Use this for initialization


	void Start () {
		instance = new Lives ();
		instance.lives = 2;
		instance.text = text;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static Lives GetInstance() {
		return instance;
	}

	public bool NoLivesRemaining() {
		return (instance.lives == 1);
	}
	public  void LivesChanged() {
		lives--;
		instance.text.text = "Lives: " + instance.lives.ToString() + "/2";
	}
}
