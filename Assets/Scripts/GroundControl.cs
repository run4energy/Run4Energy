using UnityEngine;
using System.Collections;

public class GroundControl : MonoBehaviour {

	//Material texture offset rate
	float speed = .5f;
	public static float time=1f;
	
	//Offset the material texture at a constant rate
	void Update () {
		if(Time.deltaTime == 0){
			time=1f;
		}
			time+=0.0001f;
			float offset = Time.time * speed;
			GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (0, -offset);
	}

}
