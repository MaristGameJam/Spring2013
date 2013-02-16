using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.LeftShift)){
			audio.Play();//audio source is attached to game object
		}
	}
}
