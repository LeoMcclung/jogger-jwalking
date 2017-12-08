using UnityEngine;

public class CarSpawner : MonoBehaviour {

	public float spawnDelay = .3f;

	public GameObject car;

	public Transform[] spawnPoints;

	float nextTimetoSpawn = 0f;

	void Update ()
	{
		if (nextTimetoSpawn <= Time.time)
		{
			SpawnCar ();
			nextTimetoSpawn = Time.time + spawnDelay;
		}
	}

	void SpawnCar ()
	{
		int randomIndex = Random.Range (0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints [randomIndex];

		Instantiate (car, spawnPoint.position, spawnPoint.rotation);
	}
}

