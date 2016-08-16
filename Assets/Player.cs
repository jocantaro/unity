using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	

	private float speed= 0.3f;

	public KeyCode up;
	public KeyCode down;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float direction = Input.GetAxis (this.name);
		transform.Translate (0,speed*direction,0);

		/*
		if (Input.GetKey (up)) {
			transform.Translate (0,speed,0);
		}

		if (Input.GetKey (down)) {
			transform.Translate (0,-speed,0);
		}
		*/
	}
}
