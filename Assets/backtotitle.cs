using UnityEngine;
using System.Collections;

public class backtotitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("t"))
			Application.LoadLevel ("title_screen");
	}
}
