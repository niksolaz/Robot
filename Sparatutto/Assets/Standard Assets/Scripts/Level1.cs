using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {

	// respond on collisions
	void OnCollisionEnter(Collision newCollision)
	{
		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Projectile") {
			GameManager.gm.Level1();
			Debug.Log ("AAAAAAAAAAAA");
		}
	}
}
