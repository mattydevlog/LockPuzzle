using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerMovementInLock : MonoBehaviour
{
	[SerializeField]
	private Rigidbody Occultist;

	[SerializeField]
	private float moveSpeed = 10f;

	[SerializeField]
	private float jumpSpeed = 10f;

	private bool isGrounded = true;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			Occultist.velocity = transform.position * moveSpeed;
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			Occultist.velocity = -transform.position * moveSpeed;
		}
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			Occultist.velocity = transform.up * jumpSpeed;
		}

	}


}


