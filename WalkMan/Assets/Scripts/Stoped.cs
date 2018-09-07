using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stoped : MonoBehaviour {
	
	void OnCollisionEnter ( Collision collision)
	{
		if (collision.gameObject.name == "Player")
		{
			//Application.LoadLevel ("Scene1");
			SceneManager.LoadScene("Scene2");
		} 
	} 
}
