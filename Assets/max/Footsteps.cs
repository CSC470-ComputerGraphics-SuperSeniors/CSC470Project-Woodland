using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {

	CharacterController cc;
	public AudioSource FootSteps;

	void Start()
	{
		cc = GetComponent<CharacterController>();

	}

	void Update()
	{
		if(cc.isGrounded == true && cc.velocity.magnitude > 1f && audio.isPlaying == false)
		{	
			FootSteps.volume = Random.Range(0.8f, 1.0f);
			FootSteps.pitch = Random.Range(0.9f, 1.0f);
			FootSteps.Play();

		}
	}
}