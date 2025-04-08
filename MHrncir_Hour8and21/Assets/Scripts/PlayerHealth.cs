using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    int healthpoints = 3992;
    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

        Debug.Log("Health Points: " + healthpoints);
    }
 

    // Update is called once per frame
    void Update()
    {}
    int UsePotion(int healthpoints)
    {
        return healthpoints + 400;
    }
}
