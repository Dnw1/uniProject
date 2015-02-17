using UnityEngine;
using System.Collections;

public class instructions : MonoBehaviour {
	
	public GUISkin isskin;
	
	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.24f, Screen.height * 0.18f, 550, 350), "Instructions");
		GUI.Label (new Rect (Screen.width * 0.45f, Screen.height * 0.28f, Screen.width * 0.2f, Screen.height * 0.1f), "Use upper arrow to move forward.");
		GUI.Label (new Rect (Screen.width * 0.45f, Screen.height * 0.34f, Screen.width * 0.2f, Screen.height * 0.1f), "Use bottom arrow to move backward.");
		GUI.Label (new Rect (Screen.width * 0.45f, Screen.height * 0.40f, Screen.width * 0.2f, Screen.height * 0.1f), "Use left arrow to move right.");
		GUI.Label (new Rect (Screen.width * 0.45f, Screen.height * 0.46f, Screen.width * 0.2f, Screen.height * 0.1f), "Use right arrow to move right.");
		GUI.Label (new Rect (Screen.width * 0.45f, Screen.height * 0.51f, Screen.width * 0.2f, Screen.height * 0.1f), "Use spacebar to jump.");
		if (GUI.Button (new Rect (Screen.width * 0.43f, Screen.height * 0.58f, Screen.width * 0.2f, Screen.height * 0.1f), "Main Menu")) {
			Application.LoadLevel ("MainMenu");
		}
	}
}