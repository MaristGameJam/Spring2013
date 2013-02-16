using UnityEngine;
using System.Collections;

public class rotateCylinder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.X)){
			transform.Rotate(Vector3.right*20);
		}
		if(Input.GetKeyDown(KeyCode.Z)){
			transform.Rotate(Vector3.left*20);
		}
	}
}
