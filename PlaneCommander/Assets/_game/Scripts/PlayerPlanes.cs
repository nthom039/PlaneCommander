using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlanes : MonoBehaviour
{
    public GameObject planeToChase;
    public bool chase = false;
    public bool canChase = true;
    public bool retreat = false;
    public Vector2 startPos;
    public GameObject lives;

    public void Start()
    {
        startPos = transform.position;
    }

    public void Update()
    {
        if(canChase)
        {
            if(chase)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 0);
                transform.position = Vector2.MoveTowards(transform.position, planeToChase.GetComponent<PlaneToChase>().plane.transform.position, Time.deltaTime*2);
            }
        }
        
        if(retreat)
        {
            transform.position = Vector2.MoveTowards(transform.position, startPos, Time.deltaTime*2);
            if(new Vector2(transform.position.x, transform.position.y) == startPos)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 0.1f);
                retreat = false;
                canChase = true;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject == planeToChase.GetComponent<PlaneToChase>().plane)
        {
            if(col.GetComponent<PlaneMovement>().nice)
            {
                lives.GetComponent<lives>().LoseLive();
            }
            Debug.Log(col.name);
            chase = false;
            canChase = false;
            col.GetComponent<PlaneMovement>().Hit();
            col.GetComponent<PlaneMovement>().nice = true;
            transform.position = Vector2.MoveTowards(transform.position, startPos, Time.deltaTime*2);
            retreat = true;
        }
    }
}
