﻿using UnityEngine;
using System.Collections;

public class ChangeText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
 	{
    		guiText.text = PointCounter.count.ToString();
 	}
}
