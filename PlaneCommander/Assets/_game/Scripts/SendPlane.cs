using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendPlane : MonoBehaviour
{
    public GameObject planeToChase;
    public GameObject[] playerPlanes;
    public int planesAvalible = 1;

    public void Start()
    {
        playerPlanes = GameObject.FindGameObjectsWithTag("Player Plane");
    }
    
    public void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            playerPlanes[0].GetComponent<PlayerPlanes>().chase = true;
        }
    }
}
