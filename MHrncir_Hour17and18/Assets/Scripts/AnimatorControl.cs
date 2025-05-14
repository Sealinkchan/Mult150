using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour

{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Color");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Scale");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Spin");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("UpDown");
        }
    }
}
