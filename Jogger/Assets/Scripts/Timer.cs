using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class Timer : MonoBehaviour {

	public Text timerText;
	private float startTime;
	private bool Jaywalking = true;

	void Start () {
		
	}

	void Update () {
		if (Jaywalking)
			return;
		float t = Time.time - startTime;

		string minutes = ((int)t / 60).ToString();
		string seconds = (t % 60).ToString("f1");

		timerText.text = minutes + ":" + seconds;
	}
	public void notJaywalking()
	{
		startTime = Time.time;
		Jaywalking = false;
		timerText.color = Color.yellow;
	}
}
