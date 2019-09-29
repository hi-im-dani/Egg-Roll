using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalPostSP : MonoBehaviour
{
    bool hasFinished = false;
    private void Update()
    {
        if(hasFinished == false)
            GameObject.Find("UI Overlay").GetComponent<UnityEngine.UI.Text>().text = Time.time.ToString().Substring(0,5);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.tag.Equals("Egg Players"))
        {
            GameObject.Find("UI Overlay").GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
            //if (GameObject.Find("Carton").GetComponent<GlobalVariables>.mode = 1)
            //{
            //    if (other.name.Equals("Player 1")) {
            //          GameObject.Find("UI Overlay").GetComponent<UnityEngine.UI.Text>().text = other.name + "Wins!";
            //      }
            //} else {
            string FinalTime = Time.time.ToString().Substring(0, 5);
            GameObject.Find("UI Overlay").GetComponent<UnityEngine.UI.Text>().text = ("Your time down the mountain is: " + FinalTime);
            //}
            hasFinished = true;
            other.GetComponent<Movement>().enabled = false;
            other.GetComponent<MovementP2>().enabled = false;
            


        }
    }
}
