using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree_grow : MonoBehaviour {

	// Use this for initialization
	float x;
	bool up = false;
	Vector3 tempPos;
	public float moveSpeed = 5f;
	public float turnSpeed = 30f;
	float y = 1;
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
//		transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
//		if (up) {
//			transform.position = new Vector3 (transform.position.x, 10, transform.position.z);
//			transform.Translate(Vector3.up * Time.deltaTime, Space.World);
//			print (transform.position);
//		}
//		tempPos = transform.position;
//
//		tempPos.y += 5f;
//
//		transform.position = tempPos;
//
//		print (tempPos.y);


			
		if(transform.position.y < y && up)
		transform.Translate (Vector3.up * 2f * Time.deltaTime);

	}

	public void transformX(){
		up = true;
//		print (up);

//		this.transform.position += new Vector3 (transform.position.x, 3, transform.position.z);
//		Vector3 temp = transform.position;
//		temp.y = 10.0F;
//		print (temp.y);
//		transform.position = temp;

	}	
}
