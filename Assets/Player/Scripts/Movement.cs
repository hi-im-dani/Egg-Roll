using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool DebugMovement;
    private int FramesCollidedWithTerrian;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.GetComponent<CapsuleCollider>().enabled && //if grounded)
        //{
        //
        //
        //}

        DebugWASD();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<TerrainCollider>().enabled) //other.tag == "collision tag name"
        {
            FramesCollidedWithTerrian++;
        }
    }

    void DebugWASD()
    {
        if (DebugMovement)
        {
            if (Input.GetKey(KeyCode.W))
            {

            }
            else if (Input.GetKey(KeyCode.A))
            {

            }
            else if (Input.GetKey(KeyCode.S))
            {

            }
            else if (Input.GetKey(KeyCode.D))
            {

            }
        }
    }
}
