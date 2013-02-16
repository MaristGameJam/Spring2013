using UnityEngine;
using System.Collections;

public class LegA : MonoBehaviour {
float targetAngle;
ConfigurableJoint c = new ConfigurableJoint();
	
	// Use this for initialization
	void Start () {
		targetAngle = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)){
			transform.Rotate (new Vector3(-5,0,0));
		}
	}
}
