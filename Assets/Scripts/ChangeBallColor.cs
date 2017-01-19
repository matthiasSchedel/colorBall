using UnityEngine;
using System.Collections;

public class ChangeBallColor : MonoBehaviour {
	public int updateColor;
	private int startColor = 0; //time to wait until colorchanging starts
	public GameObject ball;
	public Sprite[] spriteArray;
	private int count;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("ChangeColor", startColor , updateColor);
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void ChangeColor() {
		SpriteRenderer renderer = ball.GetComponent<SpriteRenderer> ();
		renderer.sprite = spriteArray [count];
		if (count == 3) {
			count = 0;
		} else {
			count++;
		}
	}
}
