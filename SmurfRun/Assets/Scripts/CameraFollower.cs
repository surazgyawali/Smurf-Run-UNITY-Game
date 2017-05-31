using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour {

	public Transform Player;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Player.position.x+20, 0, -10);
	
	}
}
