using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollTowardPoint : MonoBehaviour {

	public float forceAmount = 1;

	public GameObject allPoints;
	private List<Vector3> wp;
	private int index;

	private Rigidbody rb;

	public Vector3 direction;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		wp = new List<Vector3> ();
		index = 0;
		foreach (Transform child in allPoints.transform) {
			wp.Add (child.position);
		}
		direction = wp [index];
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(wp[index],transform.position ) > 1.0f) {
			rb.AddForce ((wp[index] - transform.position).normalized * forceAmount * Time.smoothDeltaTime);
		} else {
			if (index >= wp.Count) {
				index = 0;
			} else {
				Debug.Log ("waypoint hit: " + Vector3.Distance(wp[index],transform.position ));
				index++;
				direction = wp [index];
			}
		}

	}
}
