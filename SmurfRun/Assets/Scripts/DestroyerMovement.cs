using UnityEngine;
using System.Collections;

public class DestroyerMovement : MonoBehaviour {
	
	public Transform MainCamera;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (MainCamera.position.x-70, 0, -10);
		
	}
}