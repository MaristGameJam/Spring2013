using UnityEngine;
using System.Collections;
 
public class PlayerHealth : MonoBehaviour {
public int maxHealth = 100;
public int curHealth = 100;
public float healthBarLength;
public float hpY;
//public Texture2D hpbar;
 
	// Use this for initialization
	void Start () {
		healthBarLength = Screen.height / 2;
		hpY = 10;
		//hpbar = new Texture2D(60, (int)healthBarLength);
		//hpbar = Resources.Load("hp", typeof(Texture2D)) as Texture2D;
	}
 
	// Update is called once per frame
	void Update () {
		//AdjustCurrentHealth (0);
		if(Input.GetButtonDown("Jump")){
			AdjustCurrentHealth (10); //number can be tweaked
		}
	}
	void OnGUI(){
		GUI.Box(new Rect(10, 10, 60, Screen.height/2), "");
		GUI.Box(new Rect(10, hpY, 60, healthBarLength), "need\ntexture");//hpbar);
		//GUI.Box(new Rect((Screen.width-260),10,250,65), "Quest Log: \n\nGet someone to do your homework");
	}
 
	public void AdjustCurrentHealth(int adj) {
		curHealth -= adj;
 
		if(curHealth < 2)//looks weird if (curHealth < (1 || 0)) due to the way I make the hp bar decrease from top to bot
		curHealth = 2;
 
		if (curHealth > maxHealth)
			curHealth = maxHealth;
		
		float oldHBL = healthBarLength;
		healthBarLength = (Screen.height / 2) * (curHealth / (float)maxHealth);
		hpY -= (healthBarLength - oldHBL);
	}
 

}