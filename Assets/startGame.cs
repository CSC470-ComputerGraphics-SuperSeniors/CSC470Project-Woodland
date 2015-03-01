using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("d"))
						Application.LoadLevel ("scene_test");
		if (Input.GetKeyDown ("n"))
						Application.LoadLevel ("scene_night");
	}
}
