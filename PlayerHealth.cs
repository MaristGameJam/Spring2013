using UnityEngine;
using System.Collections;
 
public class PlayerHealth : MonoBehaviour {
public int maxHealth = 100;
public int curHealth = 100;
 
public float healthBarLength;
 
	// Use this for initialization
	void Start () {
		healthBarLength = Screen.height / 2;
	}
 
	// Update is called once per frame
	void Update () {
		AdjustCurrentHealth (0);
	}
	void OnGUI(){
		//GUI.Box(new Rect(10, 10, 20, healthBarLength), curHealth + "/" + maxHealth);
		GUI.Box(new Rect(10, 10, 60, healthBarLength), "Stan \nplease \nadd \ntexture");
	}
 
	public void AdjustCurrentHealth(int adj) {
		curHealth += adj;
 
		if(curHealth < 0)
		curHealth = 0;
 
		if (curHealth > maxHealth)
			maxHealth = 1;
		
		healthBarLength = (Screen.height / 2) * (curHealth / (float)maxHealth);
	}
 
}