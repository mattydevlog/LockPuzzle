using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class LockPuzzle : MonoBehaviour
{
	[SerializeField]
	private Rigidbody Occultist;

	[SerializeField]
	private float moveSpeed = 10f;

	[SerializeField]
	private float jumpHeight = 10f;


	[SerializeField]
	private Transform puzzleFrame;

	[SerializeField]
	private float rotationSpeed = 0.5f;

	private void Start()
	{
		Occultist = GetComponent<Rigidbody>();
	}


	void Update()
	{


		if (Input.GetKeyDown(KeyCode.Q))
		{
			puzzleFrame.transform.eulerAngles = new Vector3(
	puzzleFrame.transform.eulerAngles.x,
	puzzleFrame.transform.eulerAngles.y,
	puzzleFrame.transform.eulerAngles.z + 90
		);

		}

		if (Input.GetKeyDown(KeyCode.E))
		{
			puzzleFrame.transform.eulerAngles = new Vector3(
	puzzleFrame.transform.eulerAngles.x,
	puzzleFrame.transform.eulerAngles.y,
	puzzleFrame.transform.eulerAngles.z - 90
		);



		}



	}

}


