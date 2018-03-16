using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goup : MonoBehaviour {

	// Use this for initialization
	bool down = false;
	float y = 5;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < y && down)
			transform.Translate (Vector3.up * 2f * Time.deltaTime);
	}
		
	public void up_() {
	down = true;
	transform.localScale += new Vector3(0.5F, 0.5F, 0.5F);
	}
}
