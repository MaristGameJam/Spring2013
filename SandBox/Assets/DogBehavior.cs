using UnityEngine;
using System.Collections;

public class DogBehavior : MonoBehaviour {
public Ray ray;
public RaycastHit hit;
public Vector3 one, pos;
public bool makeGUI;

	
	// Use this for initialization
	void Start () {	
		one = transform.TransformDirection(Vector3.one);
		pos = transform.position;
		ray = new Ray(pos, one);
		makeGUI = false;
	}
	
	void OnGUI(){
		if(makeGUI){
			GUI.Box(new Rect(250,200,600,100), "\n\nPress <Spacebar> to ask the robot to do your homework");
			//ignore keyinputs aside from spacebar
			DisableKey (KeyCode.LeftArrow);
		}
	}
	
    void DisableKey( KeyCode key )
    {
        if( Event.current.keyCode == key && ( Event.current.type == EventType.KeyUp || Event.current.type == EventType.KeyDown ) )
        {
            Event.current.Use();
        }
    }

	// Update is called once per frame
	void Update () {
		Debug.DrawLine(ray.origin, hit.point);
		if(Physics.Raycast(ray, out hit, 15)){
			print ("lol");
			makeGUI = true;
		}
		if((Input.GetKeyDown (KeyCode.Space)) && makeGUI){
			makeGUI = false;
			audio.Play ();
		}
	}
}
