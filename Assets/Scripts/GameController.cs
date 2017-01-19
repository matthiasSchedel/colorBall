using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	private bool pause;
	public Canvas canvas;
	// Use this for initialization
	void Start () {
		pause = false;
		//canvas = GetComponent<PauseCanvas> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PauseResume() {
		if (!pause) {
			Time.timeScale = 0;
			canvas.enabled = true;
			//canvas.SetButton ();
			pause = true;

		} else {
			Time.timeScale = 1;
			pause = false;
		}
			
			
	}
}
