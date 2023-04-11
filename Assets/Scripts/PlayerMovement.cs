using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public static PlayerMovement instance;
	
	private CharacterController controller;
	public VariableJoystick joystick;

	public float speed = 12f;
	public float gravity = -9.81f;

	private Vector3 velocity;

	private void Awake()
	{
		if (instance == null)
			instance = this;
		controller = GetComponent<CharacterController>();
	}

	void Update()
	{
		Move();
		ApplyGravity();
	}

	private void Move()
	{
		var sd = transform.right * joystick.Direction.x + transform.forward * joystick.Direction.y;
		controller.Move(sd * speed * Time.deltaTime);
	}

	private void ApplyGravity()
	{
		controller.Move(velocity * Time.deltaTime);
		if (controller.isGrounded)
			velocity = new Vector3(0, -2, 0);
		else velocity += new Vector3(0, gravity * Time.deltaTime, 0);
	}
}
