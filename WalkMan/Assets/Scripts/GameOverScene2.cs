using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(transform.position.y < -10f){
			//Application.LoadLevel ("Scene1");
			SceneManager.LoadScene("Scene2");
		}
	}
}
