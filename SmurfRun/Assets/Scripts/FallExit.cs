using UnityEngine;
using System.Collections;

public class FallExit : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			Application.LoadLevel(2);
			//Debug.Break();
			return;
		}

		
	}
}
