using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecar : MonoBehaviour
{
    public bool left;
    public bool right;
    public bool forward;
    public bool back;
    public bool debuffActive;
    [SerializeField] float speed = 2f;
    [SerializeField] float speedDebuff = 0.5f;
    Vector3 posOffset;
    // Start is called before the first frame update
    void Start()
    {
        posOffset = new Vector3(0, 0.2f, 0);
        left = false;
        right = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(left){
            gameObject.transform.Rotate(0.0f, -3.0f, 0.0f, Space.Self);
        }
        else if(right){
            gameObject.transform.Rotate(0.0f, 3.0f, 0.0f, Space.Self);
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

    private void FixedUpdate()
    {
        Vector3 pos = transform.position + posOffset;
        RaycastHit hit;
        Physics.Raycast(pos, Vector3.down, out hit);

        if (hit.collider.tag == "Floor" && !debuffActive)
        {
            debuffActive = true;
            speed *= speedDebuff;
        }
        else if (hit.collider.tag != "Floor" && debuffActive)
        {
            debuffActive = false;
            speed = speed / speedDebuff;
        }
    }

    /*private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Floor")
        {
            debuffActive= true;
            speed *= speedDebuff;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            debuffActive = false;
            speed = speed / speedDebuff;
        }
    }*/
}
