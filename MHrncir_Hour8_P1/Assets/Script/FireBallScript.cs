using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int x = TakeDamageFromFireball();
        //Debug.Log("Player health: " + x);

        //int y = TakeDamageFromFireball(25);
        //Debug.Log("Player health: " + y);

        int z = TakeDamageFromFireball(30, 50);
        Debug.Log("Player health: " + z); 
    }
    // Update is called once per frame
    void Update()
    {
                 
    }
    //int TakeDamageFromFireball()
    //int TakeDamageFromFireball(int damage)
    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        //int playerHealth = 100;
        //return playerHealth - 5;

        //int playerHealth = 100;
        //return playerHealth - damage;

        return playerHealth - damage;
    }
}   
