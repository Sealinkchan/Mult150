using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = 0.5f; // Speed of the texture scroll
    Renderer spawn;
    float offset = 0; // Offset for the texture

    void Start()
    {
        spawn = GetComponent<Renderer>();
        // Get the Renderer component from the GameObject
    }

    void Update()
    {
        // Increase offset based on time
        offset += Time.deltaTime * speed;
        // Keep offset between 0 and 1
        if (offset > 1)
            offset -= 1;
        // Apply the offset to the material
        spawn.material.mainTextureOffset = new Vector2(0, offset);
    }
}