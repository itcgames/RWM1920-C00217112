using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderParachute : MonoBehaviour
{
	[SerializeField] private GameObject parachute;

	private void OnTriggerEnter(Collider other)
	{
		parachute.SetActive(false);
		gameObject.GetComponent<Rigidbody>().useGravity = true;
	}
}
