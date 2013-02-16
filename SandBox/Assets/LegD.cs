using UnityEngine;
using System.Collections;

public class LegD : MonoBehaviour {
float targetAngle;
//public ConfigurableJoint c;
	
	// Use this for initialization
	void Start () {
		//targetAngle = 30;
		//c = GetComponent<ConfigurableJoint>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.D) && !DogBehavior.makeGUI && (PlayerHealth.curHealth >2)){
			transform.Rotate (new Vector3(-5,0,0));
			PlayerHealth.AdjustCurrentHealth(1);
			/*
			Quaternion targetRotation = Quaternion.AngleAxis(targetAngle, Vector3.right);
			c.targetRotation = targetRotation;
			*/
		}
	}
}
