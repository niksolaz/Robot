using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //This condition is related to a ball that falls beyond the plan and consequently recharging the scene.
		if (transform.position.y < -5.0f ){
            Application.LoadLevel("scene");
        }

        //Create the condition that ensures that the application goes in GameOver
	}
}