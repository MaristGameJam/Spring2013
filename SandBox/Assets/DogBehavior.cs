using UnityEngine;
using System.Collections;

public class DogBehavior : MonoBehaviour {
public Ray ray;
public RaycastHit hit;
public Vector3 one, pos;
public static bool makeGUI;
private bool makeGUIflag;
	
	// Use this for initialization
	void Start () {	
		one = transform.TransformDirection(Vector3.one);
		pos = transform.position;
		ray = new Ray(pos, one);
		makeGUI = false;
		makeGUIflag = false;
	}
	
	void OnGUI(){
		if(makeGUI){
			GUI.Box(new Rect(250,200,600,100), "\n\nPress <Spacebar> to ask the robot to do your homework");
		}
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine(ray.origin, hit.point);
		if(Physics.Raycast(ray, out hit, 15) && !makeGUIflag){
			print ("lol");
			makeGUI = true;;
			makeGUIflag = true;
		}
		if((Input.GetKeyDown (KeyCode.Space)) && (makeGUI)){
			makeGUI = false;
			audio.Play ();
			
		}
	}
}
