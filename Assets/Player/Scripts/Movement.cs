using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool DebugMovement;
    public int Speed;
    public int JumpForce;
    private int FramesCollidedWithTerrian;
    

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("1X360_LStickY"));
        print(Input.GetAxis("1X360_LStickX"));
        transform.GetComponent<Rigidbody>().AddForce(GameObject.Find("Camera").transform.forward * Speed * -Input.GetAxisRaw("1X360_LStickY"));
        transform.GetComponent<Rigidbody>().AddForce(GameObject.Find("Camera").transform.right * Speed * Input.GetAxisRaw("1X360_LStickX"));
        DebugWASD();

    }

    void DebugWASD()
    {
        if (DebugMovement)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.GetComponent<Rigidbody>().AddForce(GameObject.Find("Camera").transform.forward * Speed);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.GetComponent<Rigidbody>().AddForce(-GameObject.Find("Camera").transform.right * Speed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.GetComponent<Rigidbody>().AddForce(-GameObject.Find("Camera").transform.forward * Speed);

            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.GetComponent<Rigidbody>().AddForce(GameObject.Find("Camera").transform.right * Speed);
            }
        }
    }
}
