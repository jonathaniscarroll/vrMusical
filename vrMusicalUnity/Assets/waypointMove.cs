using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointMove : MonoBehaviour {

	public GameObject allPoints;
	private List<Vector3> wp;
	private int index;
	public float speed;

	// Use this for initialization
	void Start () {
		wp = new List<Vector3> ();
		index = 0;
		foreach (Transform child in allPoints.transform) {
			wp.Add (child.position);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position != wp [index]) {
			transform.position = Vector3.MoveTowards (transform.position, wp [index], Time.deltaTime * speed);
		} else {
			if (index >= wp.Count) {
				index = 0;
			} else {
				index++;
			}
		}
	}
}
