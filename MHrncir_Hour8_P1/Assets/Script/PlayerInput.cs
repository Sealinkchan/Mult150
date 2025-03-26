using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if(hVal != 0)
            Debug.Log("Horizontal movement selected: " + hVal);
        if(vVal != 0)
            Debug.Log("Vertical movement selected: " + vVal);*/

        /*if(Input.GetKey(KeyCode.M))
            Debug.Log("The 'M' key is pressed down");
        if(Input.GetKeyDown(KeyCode.O))
            Debug.Log("The 'O' key was pressed");*/
        
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if(mxVal != 0)
            Debug.Log("Mouse X movement selected: " + mxVal);
        if(myVal != 0)
            Debug.Log("Mouse Y movement selected: " + myVal);
    }
}
