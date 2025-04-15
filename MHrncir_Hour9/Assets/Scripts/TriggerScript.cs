using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered the " + gameObject.name);
    }
    void OnTriggerStay (Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered the " + gameObject.name);
    }
    void OnTriggerExit (Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered the " + gameObject.name);
    }
}
