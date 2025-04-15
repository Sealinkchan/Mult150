using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour

{
    private int bounceCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        bounceCount = 0;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        bounceCount++;

        Debug.Log("Bounce Count:" + bounceCount); 
    }
}
