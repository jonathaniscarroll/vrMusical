using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reduceFog : MonoBehaviour {

	public GameObject target;
	private float startDist;
	private float startDens;

	// Use this for initialization
	void Start () {
		startDens = RenderSettings.fogDensity;
		startDist = Vector3.Distance (target.transform.position,transform.position);
		StartCoroutine (clearFog ());
	}

	 IEnumerator clearFog(){
		float dist = Vector3.Distance (target.transform.position,transform.position);
		while (dist > .10f) {
			dist = Vector3.Distance (target.transform.position,transform.position);
			RenderSettings.fogDensity = dist / startDist * startDens;
			Debug.Log ("dist: " + dist + " " + dist / startDist * startDens);
			yield return null;
		}
	}
}
