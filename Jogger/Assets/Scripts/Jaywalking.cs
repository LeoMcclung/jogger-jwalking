using UnityEngine;
using System.Collections;


public class Jaywalking : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Costanza_0") {
			Debug.Log ("In the zone!");
			GameObject.Find ("Costanza_0").SendMessage ("notJaywalking");
		}
	}
}
