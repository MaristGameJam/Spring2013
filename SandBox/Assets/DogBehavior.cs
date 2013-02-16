using UnityEngine;
using System.Collections;

public class DogBehavior : MonoBehaviour {
public Ray ray;
public RaycastHit hit;
public Vector3 one, pos;

	
	// Use this for initialization
	void Start () {	
		one = transform.TransformDirection(Vector3.one);
		pos = transform.position;
		ray = new Ray(pos, one);
	}
	void dogTalk(){
		//audio.Play();
		
	}
	// Update is called once per frame
	void Update () {
		Debug.DrawLine(ray.origin, hit.point);
		if(Physics.Raycast(ray, out hit, 15)){
			dogTalk ();
		}
	}
}
