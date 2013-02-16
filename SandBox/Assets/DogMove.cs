using UnityEngine;
using System.Collections;

public class DogMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal") > 0){
			transform.Translate(0,0,1);
			print ("test");
		}
		if(Input.GetAxis("Horizontal") < 0){
			transform.Translate(0,0,-1);
		}
	}
}
