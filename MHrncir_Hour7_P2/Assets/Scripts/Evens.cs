using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    void Start()
    {
        for (int i = 22; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }            
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
