using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {
	
	//public GameControlScript control;
	private float objectSpeed = -20f;
	
	
	void Update () {
		
		transform.Translate(new Vector3(0, objectSpeed, 0)*Time.deltaTime*GroundControl.time);
		
	}
}