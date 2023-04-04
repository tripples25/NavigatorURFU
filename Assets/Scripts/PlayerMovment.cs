using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
	public CharacterController controller;
	public VariableJoystick joystick;

	public float speed = 12f;
	public float gravity = -9.81f;

	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;

	Vector3 velocity;
	bool isGrounded;

	void Update()
	{
		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

		if (isGrounded && velocity.y < 0)
		{
			velocity.y = -2f;
		}

		Vector3 move = transform.right * joystick.Horizontal + transform.forward * joystick.Vertical;

		controller.Move(move * speed * Time.deltaTime);

		velocity.y += gravity * Time.deltaTime;

		controller.Move(velocity * Time.deltaTime);
	}
}
