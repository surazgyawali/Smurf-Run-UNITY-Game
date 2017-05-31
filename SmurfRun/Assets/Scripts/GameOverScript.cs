using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score=0;
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
	
	}
	void OnGUI()
	{
				GUI.Button (new Rect (Screen.width / 2 - 50, 50, 110, 90), "GAME OVER");
				GUI.Label (new Rect (Screen.width / 2 - 30, 200, 60, 30), "Score:" + score);

				if (GUI.Button (new Rect (Screen.width / 2 - 50,250,100,60), "Retry?")) {
						Application.LoadLevel (1);
				}
		}
	

}
