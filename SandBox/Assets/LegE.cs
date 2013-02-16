using UnityEngine;
using System.Collections;

public class LegE : MonoBehaviour {
float targetAngle;
ConfigurableJoint c = new ConfigurableJoint();
	
	// Use this for initialization
	void Start () {
		targetAngle = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E)){
			transform.Rotate (new Vector3(-10,0,0));
		}
	}
}
