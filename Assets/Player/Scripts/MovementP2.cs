using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP2 : MonoBehaviour
{
    public bool DebugMovement;
    private int Speed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = transform.parent.Find("Player 1").GetComponent<Movement>().Speed;
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("2X360_LStickY"));
        print(Input.GetAxis("2X360_LStickX"));
        transform.GetComponent<Rigidbody>().AddForce(GameObject.Find("Camera").transform.forward * Speed * -Input.GetAxisRaw("2X360_LStickY"));
        transform.GetComponent<Rigidbody>().AddForce(GameObject.Find("Camera").transform.right * Speed * Input.GetAxisRaw("2X360_LStickX"));
        DebugWASD();

    }

    void DebugWASD()
    {
        if (DebugMovement)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.GetComponent<Rigidbody>().AddForce(GameObject.Find("Camera").transform.forward * Speed);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.GetComponent<Rigidbody>().AddForce(-GameObject.Find("Camera").transform.right * Speed);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.GetComponent<Rigidbody>().AddForce(-GameObject.Find("Camera").transform.forward * Speed);

            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.GetComponent<Rigidbody>().AddForce(GameObject.Find("Camera").transform.right * Speed);
            }
        }
    }
}
