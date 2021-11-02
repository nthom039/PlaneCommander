using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public GameObject provence;
    public bool inFlight = false;
    public bool nice = true;
    public bool hit = false;

    void Update()
    {
        if(inFlight)
        {
            
            transform.position = Vector2.Lerp(transform.position, provence.transform.position, Time.deltaTime*0.25F);
        }
    }

    public void Hit()
    {
        hit = false;
        this.enabled = false;
        transform.position = new Vector2(provence.transform.position.x, provence.transform.position.y);
        this.enabled = true;
    }
}
