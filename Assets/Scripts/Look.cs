using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
	public float mouseSensitivity = 100f;
	public Transform playerBody;
	public VariableJoystick joystick;

	float xRotation = 0f;

	void Update()
	{
		float mouseX = joystick.Horizontal * mouseSensitivity * Time.deltaTime;
		float mouseY = joystick.Vertical * mouseSensitivity * Time.deltaTime;

		xRotation -= mouseY;
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);

		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
		playerBody.Rotate(Vector3.up * mouseX);
	}
}
