using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecar : MonoBehaviour
{
    public bool left;
    public bool right;
    public bool forward;
    public bool back;
    int speed = 2;
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
            gameObject.transform.Rotate(0.0f, -0.75f, 0.0f, Space.Self);
        }
        else if(right){
            gameObject.transform.Rotate(0.0f, 0.75f, 0.0f, Space.Self);
        }

        if(forward){
            transform.Translate(0, 0, speed * Time.deltaTime, Space.Self);
        }
        else if(back){
            transform.Translate(0, 0, -speed * Time.deltaTime, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            forward = true;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            back = true;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            right = false;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            left = false;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            forward = false;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            back = false;
        }
        
        
    }
}
