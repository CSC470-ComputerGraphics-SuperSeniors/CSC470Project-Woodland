﻿using UnityEngine;
using System.Collections;

public class KillStreakSounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(PointCounter.count == 1){
		 	audio.Play();
		}
	
	}
}
