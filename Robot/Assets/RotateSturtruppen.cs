﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSturtruppen : MonoBehaviour {

	void Update () 
	{
		transform.Rotate (new Vector3 (0, 180, 0) * Time.deltaTime);
	}
		
}
