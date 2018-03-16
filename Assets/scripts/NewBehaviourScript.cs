using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {


	void transformX(){
		transform.position = new Vector3 (21.86F, 5.0F, 23.6F);
		print (transform.position.x);
	}	
}
