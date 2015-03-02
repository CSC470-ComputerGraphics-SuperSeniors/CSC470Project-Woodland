using UnityEngine;
using System.Collections;

public class splodeScript : MonoBehaviour {

	public GameObject explosion;
		
	public void Explode( Vector3 position ) {
		Instantiate( explosion, position, Quaternion.identity );
	}
}
