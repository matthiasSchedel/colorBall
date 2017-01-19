using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseCanvas : MonoBehaviour {
	private Button pause;
	// Use this for initialization
	void Start () {
		pause = GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetButton() {
		pause.enabled = true;
	}
}
