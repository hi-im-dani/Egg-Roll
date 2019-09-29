using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP2 : MonoBehaviour
{
    public bool DebugMovement;
    public int Speed;
    private int FramesCollidedWithTerrian;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("2X360_LStickY"));
        print(Input.GetAxis("2X360_LStickX"));
        transform.GetComponent<Rigidbody>().AddForce(GameObject.Find("Camera").transform.forward * Speed * -Input.GetAxis("1X360_LStickY"));
        transform.GetComponent<Rigidbody>().AddForce(GameObject.Find("Camera").transform.right * Speed * Input.GetAxis("1X360_LStickX"));
        DebugWASD();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<TerrainCollider>().enabled) //other.tag == "collision tag name"
        {
            FramesCollidedWithTerrian++;
        }
        else
        {
            FramesCollidedWithTerrian = 0;
        }
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
