using UnityEngine;
using System.Collections;

public class DogBehavior : MonoBehaviour {
public Ray ray;
public RaycastHit hit;
public Vector3 one, pos;
public static bool makeGUI;
private bool makeGUIflag;
private int options;
public AudioClip [] myAudioClips;
	// Use this for initialization
	void Start () {	
		one = transform.TransformDirection(Vector3.one);
		pos = transform.position;
		ray = new Ray(pos, one);
		makeGUI = false;
		makeGUIflag = false;
		options = 1;
	}
	
	void OnGUI(){
		if(makeGUI){
			GUI.Box(new Rect(250,200,600,130), "\nDo my homework \n\npantpantpantpantpantpantpant \n\nfuck this I'm going home");
		}
	}
	
	void cycleOptions(){
		if(options < 1)
			options = 1;
		if(options > 3)
			options = 3;
		if(Input.GetKeyDown(KeyCode.DownArrow))
			options--;
		if(Input.GetKeyDown(KeyCode.UpArrow))
			options++;
		if(Input.GetKeyDown(KeyCode.Space)){		
			//audio.clip = myAudioClips[0];
			//audio.Play();
			//print (myAudioClips.length);
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
		if(makeGUI){
			cycleOptions();
		}
	}
}
					//makeGUI = false;
					//audio.Play ();