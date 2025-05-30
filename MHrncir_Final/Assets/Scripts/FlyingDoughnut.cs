using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingDoughnut : MonoBehaviour
{/*
	void Update()
	{
		transform.Translate(0, 0, -20f * Time.unscaledDeltaTime, Space.World);
	}
*/
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("Doughnut collected!");
			Destroy(gameObject);
		}
	}
}
