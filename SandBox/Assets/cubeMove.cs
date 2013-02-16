using UnityEngine;
using System.Collections;

public class cubeMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal") > 0){
			transform.Translate(0,1,0);
		}
		if(Input.GetAxis("Horizontal") < 0){
			transform.Translate(0,-1,0);
		}
		if(Input.GetButtonDown ("Vertical")){
			transform.Translate(0,1,0);
		}
	}
}
