using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour{

	public float moveSpeed = 5f;
	public Rigidbody2D rigidbody2D;

    Vector2 movement;

	// Update is called once per frame
	void Update()
	{
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

	}

	private void FixedUpdate()
	{
        rigidbody2D.MovePosition(rigidbody2D.position + movement * moveSpeed * Time.fixedDeltaTime);
	}
}