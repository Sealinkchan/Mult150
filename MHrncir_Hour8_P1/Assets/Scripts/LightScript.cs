using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light lightcomponent;

	void Start()
    {
        lightcomponent = GetComponent<Light>();

        if (lightcomponent == null)
        {
            Debug.Log("Light not working.");
        }
    }
	// Update is called once per frame
	void Update()
    {
		if (lightcomponent != null)
        {
            lightcomponent.enabled = Input.GetKey(KeyCode.L);
		}
	}
}