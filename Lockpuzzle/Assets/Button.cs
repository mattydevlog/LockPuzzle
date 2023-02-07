using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
	[SerializeField]
	private GameObject button;

	private void OnCollisionEnter(Collision collision)
	{
		if (button != null)
		{
			Debug.Log("You unlocked button");
		}
	}
}
