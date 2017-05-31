using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public GUISkin gskin;
	void OnGUI(){

		if (GUI.Button (new Rect (Screen.width / 2, 0, 90, 30), "Play")) {
			Application.LoadLevel (1);
		}
		
	}


	}

