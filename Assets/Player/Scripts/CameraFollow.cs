using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 pos;
    void Start()
    {
        pos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = GameObject.Find("egg").transform.position + pos;
    }
}
