using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deer_moving : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * 0.2f * Time.deltaTime);
	}
}
