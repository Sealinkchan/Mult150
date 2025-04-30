using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfSpawns = 10;

    void Start()
    {
        for (int i = 0; i < numberOfSpawns; i++)
        {
            Vector3 offset = new Vector3(10, 0, i * 10);
            Instantiate(prefab, transform.position + offset, transform.rotation);
        }
    }

    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
