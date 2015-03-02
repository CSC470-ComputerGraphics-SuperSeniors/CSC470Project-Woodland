using UnityEngine;
using System.Collections;



public class PointCounter : MonoBehaviour 
{ 
	public static int count = 0;
	public static int totalBugs = 0;

	void Update(){
		totalBugs = totalBugs - count;	
	}

}
