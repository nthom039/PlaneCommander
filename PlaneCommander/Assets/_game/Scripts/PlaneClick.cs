using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneClick : MonoBehaviour
{
    public Text planeInfoText;
    public bool nice;
    public GameObject provence;

    void OnMouseDown()
    {
        nice = this.GetComponent<PlaneMovement>().nice;
        planeInfoText.GetComponent<PlaneToChase>().plane = this.gameObject;
        planeInfoText.text = "The plane is a ";
        if(nice)
        {
            planeInfoText.text += "friend.";
        }
        else
        {
            planeInfoText.text += "enemy.";
        }
        planeInfoText.text += "\n\nIt's going to " + provence.name;
    }
}
