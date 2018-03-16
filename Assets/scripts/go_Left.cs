using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go_Left : MonoBehaviour {

	// Use this for initialization
	bool left = false;
	float y = -1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.eulerAngles.x < 80 && transform.eulerAngles.x > -90 && left) {
			transform.Rotate (Vector3.right, 80 * Time.deltaTime);
			print ("roation x");
			print (transform.eulerAngles.x);
		}



		if(transform.position.y > y && left && transform.position.x > 13 && transform.position.z > 41 )
			transform.Translate (Vector3.down * 2f * Time.deltaTime);

	}

	public void goLeft(){
		left = true;
	}
}
