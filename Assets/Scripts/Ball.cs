using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public int lives;
	public float startSpeed;
	public float acceleration;
	public GameObject ball;
	public Sprite[] spriteArray;
	private int arraySize;
	private int count;
	private static string[] tags = { "Red", "Green", "Blue", "Yellow" };
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Lives", lives);
		arraySize = spriteArray.Length;
		ChangeColor ();
		count = 0;
	}

	// Update is called once per frame
	void Update () {

	}

	public void ReSpawn() {
		ball.transform.position += new Vector3 (0, 6, 0);
		Rigidbody2D rb = ball.transform.GetComponent<Rigidbody2D> ();

		if((count++ % 5) == 0)
			rb.gravityScale += 0.1f;
		
		rb.velocity = new Vector3 ();
		ChangeColor ();
	}

	void ChangeColor() {
		SpriteRenderer renderer = ball.GetComponent<SpriteRenderer> ();
		int color = Random.Range (0, arraySize);
		renderer.sprite = spriteArray [color];
		this.tag = tags [color];
	}
}
