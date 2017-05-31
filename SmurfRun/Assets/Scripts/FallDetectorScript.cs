using UnityEngine;
using System.Collections;

public class FallDetectorScript : MonoBehaviour {
	
	public Transform MainCamera;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (MainCamera.position.x, -25, -10);
		
	}
}