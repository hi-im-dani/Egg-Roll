using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalPostMP : MonoBehaviour
{
    bool hasFinished = false;
    private void Update()
    {
        if (hasFinished == false)
            GameObject.Find("UI Overlay").GetComponent<UnityEngine.UI.Text>().text = Time.time.ToString().Substring(0, 5);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag.Equals("Egg Players"))
        {
            hasFinished = true;
            GameObject.Find("UI Overlay").GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
            GameObject.Find("UI Overlay").GetComponent<UnityEngine.UI.Text>().text = other.name + " Wins!";
            }
        }
    }
