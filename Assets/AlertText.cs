using UnityEngine;
using System.Collections;

public class AlertText : MonoBehaviour {
	private bool fiveCount = false;
	private bool tenCount = false;
	private bool fifteenCount = false;
	private bool twentyFiveCount = false;
	private bool fourtyFiveCount = false;
	public AudioClip killStreak1;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update()
	{	

		if(PointCounter.count == 0){
			guiText.text = "";
		}	
		if(PointCounter.count == 1 && !fiveCount){
			StartCoroutine(ShowMessage(2, PointCounter.count, " Kill!"));
			fiveCount = true;
		}
		if(PointCounter.count == 10 && !tenCount){
			StartCoroutine(ShowMessage(2, PointCounter.count, " Kills!"));
			tenCount = true;
		}
		if(PointCounter.count == 15 && !fifteenCount){
			StartCoroutine(ShowMessage(2, PointCounter.count, " Kills!"));
			fifteenCount = true;
		}
		if(PointCounter.count == 25 && !twentyFiveCount){
			StartCoroutine(ShowMessage(2, PointCounter.count, " Kills!"));
			twentyFiveCount = true;
		}
		if(PointCounter.count == 45 && !fourtyFiveCount){
			StartCoroutine(ShowMessage(2, PointCounter.count, " Kills!"));
			fourtyFiveCount = true;
		}
	}

	IEnumerator ShowMessage (float delay, int killCount, string message) {
     guiText.text = killCount.ToString() + message;
     guiText.enabled = true;
     yield return new WaitForSeconds(delay);
     guiText.enabled = false;
 }
}
