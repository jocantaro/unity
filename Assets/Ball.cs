using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	int speedx;
	int speedy;

	float speed;

	// Use this for initialization
	void Start () {
		speed = Random.Range (5, 10);

		speedx= Random.Range (0, 2);

		if (speedx == 0) {
			speedx = 1;
		} else {
			speedx = -1;
		}

		speedy= Random.Range (0, 2);

		if (speedy == 0) {
			speedy = 1;
		} else {
			speedy = -1;
		}

		GetComponent<Rigidbody> ().velocity = new Vector3 (speed * speedx, speed * speedy, 0);

	}

	// Update is called once per frame
	void Update () {

	}
}
