using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        DontDestroyOnLoad(GameObject.Find("Carton"));
    }

    // Update is called once per frame
    void Update()
    {

    }


}
