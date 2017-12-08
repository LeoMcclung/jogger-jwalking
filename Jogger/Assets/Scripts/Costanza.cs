using UnityEngine;
using UnityEngine.SceneManagement; 

public class Costanza : MonoBehaviour {

	public Rigidbody2D rb;
	public GameObject ExplosionGO;

	Animator anim;

	void Update () {

		if (Input.GetKeyDown (KeyCode.RightArrow))
			rb.MovePosition (rb.position + Vector2.right);
		else if (Input.GetKeyDown (KeyCode.LeftArrow))
			rb.MovePosition (rb.position + Vector2.left);
		else if (Input.GetKeyDown (KeyCode.UpArrow))
			rb.MovePosition (rb.position + Vector2.up);
		else if (Input.GetKeyDown (KeyCode.DownArrow))
			rb.MovePosition (rb.position + Vector2.down);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			PlayExplosion ();
			Destroy (gameObject);
			Debug.Log ("CHOO LOSE!");
//			SceneManager.LoadScene (sceneBuildIndex: 2);
		}
	}
	void PlayExplosion()
	{
		GameObject explosion = (GameObject)Instantiate (ExplosionGO);
		explosion.transform.position = transform.position;
	}
}
