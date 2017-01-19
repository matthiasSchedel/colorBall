using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LastScore : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		text.text = "Your score was: " + PlayerPrefs.GetInt ("LastScore");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
