using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 25f;
	public float mapwidth = 20f;

	private Rigidbody2D rb;

	void Start() {
		// sets the rb variable to the RigidBody2D Component attached to 'player'
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		// sets the new position from Input to var x
		float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
		Vector2 newPosition = rb.position + Vector2.right * x;
		newPosition.x  = Mathf.Clamp(newPosition.x, - mapwidth, mapwidth);
		// tells the rigidbody component to move based on 'x'
		rb.MovePosition(newPosition);
	}

	// called whenever there is a collision
	void OnCollisionEnter2D() {
		Debug.Log("Player Got Hit !");
		FindObjectOfType<GameManager>().EndGame();
	}
}
