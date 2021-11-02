using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPort : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Plane")
        {
            if(col.GetComponent<PlaneMovement>().inFlight){
                if(col.GetComponent<PlaneMovement>().provence.transform.position == this.transform.position)
                {
                    col.GetComponent<PlaneMovement>().inFlight = false;
                    col.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0.01f);
                    col.GetComponentInParent<PlanePicker>().planesInAir --;
                    GameObject.Find("PlaneToChase").GetComponent<PlaneToChase>().plane = null;
                    if(col.GetComponent<PlaneMovement>().nice == false)
                    {
                        GameObject.Find("Lives").GetComponent<lives>().LoseLive();
                    }

                    Debug.Log(GameObject.Find("PlanePlayer").GetComponent<PlayerPlanes>().planeToChase + " _ " + col.gameObject);
                    if(GameObject.Find("PlanePlayer").GetComponent<PlayerPlanes>().chase && GameObject.Find("PlaneToChase").GetComponent<PlaneToChase>().plane == col.gameObject)
                    {
                        GameObject.Find("PlanePlayer").GetComponent<PlayerPlanes>().chase = false;
                        GameObject.Find("PlanePlayer").GetComponent<PlayerPlanes>().retreat = true;
                    }
                }
            }
        }
    }
}
