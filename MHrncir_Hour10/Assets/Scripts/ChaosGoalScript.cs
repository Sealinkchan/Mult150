using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoalScript : MonoBehaviour
{
    private int collisionCount = 0;
    public int collisionThreshold = 5;
    public bool isSolved = false;
    void OnTriggerEnter (Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            collisionCount++;
            Destroy (collidedWith);
            Debug.Log (collisionCount);

            if (collisionCount >= collisionThreshold)
            {
                isSolved = true;
                GetComponent<Light>().enabled = false;
            }
        }
    }

}