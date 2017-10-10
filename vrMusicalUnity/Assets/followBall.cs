using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followBall : MonoBehaviour {

	public Transform ball;

	void Update() {
//		transform.position = ball.position - (ball.forward * 5);

		// This should keep camera looking towards your ball
		transform.LookAt(ball);

	}

}
