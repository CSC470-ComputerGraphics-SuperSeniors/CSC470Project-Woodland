using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {

	CharacterController cc;

	void Start()
	{
		cc = GetComponent<CharacterController>();

	}

	void Update()
	{
		if(cc.isGrounded == true && cc.velocity.magnitude > 1f && audio.isPlaying == false)
		{	
			if(cc.velocity.magnitude > 3f){
				audio.volume = Random.Range(0.8f, 1);
				audio.pitch = Random.Range(0.8f, 1.1f);
				audio.Play();
				audio.Play();
			}
			audio.volume = Random.Range(0.8f, 1);
			audio.pitch = Random.Range(0.8f, 1.1f);
			audio.Play();

		}
	}
}