using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    public float Bouncefactor;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.GetComponent<Rigidbody>().velocity = -other.transform.GetComponent<Rigidbody>().velocity / Bouncefactor;
    }
}
