using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go_down : MonoBehaviour {

	bool up = false;
	// Use this for initialization
	float y = -1.5F;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y > y && up)
			transform.Translate (Vector3.down * 8f * Time.deltaTime);
	}

	public void goDown() {
		up = true;

	}
}
