using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public float movementFactor = 10f;

	public void EndGame() {
		StartCoroutine(RestartLevel());
	}

	IEnumerator RestartLevel() {
		Time.timeScale = 1f / movementFactor;
		Time.fixedDeltaTime = Time.fixedDeltaTime / movementFactor;
		// before 1 second
		yield return new WaitForSeconds(1f / movementFactor);
		// after 1 second
		Time.timeScale = 1f;
		Time.fixedDeltaTime = Time.fixedDeltaTime * movementFactor;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
