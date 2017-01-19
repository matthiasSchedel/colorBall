using UnityEngine;
using System.Collections;

public class Triangle : MonoBehaviour {
	public AudioSource source;
	public AudioSource source2;
	//public AudioClip clip;
	public LevelManager levelManager;
	public ScoreKeeper scoreKeeper;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (this.tag == coll.gameObject.tag) {
			coll.gameObject.SendMessage ("ReSpawn");
			scoreKeeper.SendMessage ("UpdateScore");
			source.volume = PlayerPrefs.GetFloat ("MasterVolume");
			source.Play ();
		} else {
			Debug.Log ("wrong color");
			source2.volume = PlayerPrefs.GetFloat ("MasterVolume");
			source2.Play();
			Lives lives = Lives.GetInstance ();
			if (lives.NoLivesRemaining()) { 
				levelManager.loadLevel ("Game Over 03");
			} else {
				lives.LivesChanged ();
				coll.gameObject.SendMessage ("ReSpawn");
			}

		}


	}


}
