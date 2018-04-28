using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockspawner : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject obstacle;
	private float timeToSpawn = 2f;
	public float timeBetweenWaves = 4f;

	// Use this for initialization
	void Update() {
		if (Time.time >= timeToSpawn) {
			SpawnBlocks();
			timeToSpawn = Time.time + timeBetweenWaves;
		}
	}

	void SpawnBlocks() {
		int randomPoint = Random.Range(0, spawnPoints.Length);
		for (int i = 0; i < spawnPoints.Length; i++) {
			if (i != randomPoint) {
				Instantiate(obstacle, spawnPoints[i]);
			}
		}
	}
}
