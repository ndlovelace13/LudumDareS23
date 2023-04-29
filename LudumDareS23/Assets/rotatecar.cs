using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecar : MonoBehaviour
{
    public bool left;
    public bool right;
    // Start is called before the first frame update
    void Start()
    {
        left = false;
        right = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(left){
            gameObject.transform.Rotate(0.0f, -0.5f, 0.0f, Space.Self);
        }
        else if(right){
            gameObject.transform.Rotate(0.0f, 0.5f, 0.0f, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            right = false;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            left = false;
        }
        
        
    }
}
