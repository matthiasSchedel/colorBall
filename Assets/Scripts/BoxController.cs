using UnityEngine;
using System.Collections;

public class BoxController : MonoBehaviour {
	public GameObject box;
	private float oldRotation;
	private float count;
	private float rotate;
	private Animator myAnimator;
	private bool isRotating;
	private float rotationSpeed;
	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();
		myAnimator.speed = 0.1f;
		isRotating = false;
		count = 0;
		rotationSpeed = 350;
	}
	
	// Update is called once per frame
	void Update () {
		if (isRotating) {
			Rotate ();
		}

	}
	void Reset() {


	}

	void Rotate() {
		if (count + Time.deltaTime * rotationSpeed >= 90) {
			float r = 90 - count;
			box.transform.Rotate (0, 0, rotate * r);
			isRotating = false;
			return;
		}
		count += Time.deltaTime * rotationSpeed;
		box.transform.Rotate (0, 0, rotate * Time.deltaTime * rotationSpeed);
	}

	public void TurnLeft() {
		if (!isRotating) {
			count = 0;
			isRotating = true;
			rotate = 1;
		}

	}


	public void TurnRight() {
		if (!isRotating) {
			count = 0;
			isRotating = true;
			rotate = -1;
		}
	}
}
