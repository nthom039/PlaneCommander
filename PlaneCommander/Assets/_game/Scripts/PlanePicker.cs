using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePicker : MonoBehaviour
{
    public GameObject[] planes;
    public GameObject[] provences;
    public int planesInAir = 0;
    public float timer = 0;
    private bool canSend = true;

    void Awake()
    {
        planes = GameObject.FindGameObjectsWithTag("Plane");
        provences = GameObject.FindGameObjectsWithTag("Provence");
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(Mathf.Round(timer) % 5 == 1)
        {
            canSend = true;
        }
        Debug.Log(Mathf.Round(timer) + " _ " + (Mathf.Round(timer) % 5));
        if((canSend == true) && (Mathf.Round(timer) % 5 == 0) && (planesInAir != planes.Length))
        {
            canSend = false;
            Debug.Log("Click");
            int ranPlane = Random.Range(0, planes.Length);
            int ranProvence = Random.Range(0, provences.Length);
            while(planes[ranPlane].GetComponent<PlaneMovement>().inFlight == true)
            {
                ranPlane = Random.Range(0, planes.Length);
            }
            while((planes[ranPlane].transform.position.x, planes[ranPlane].transform.position.y) == (provences[ranProvence].transform.position.x, provences[ranProvence].transform.position.y))
            {
                ranProvence = Random.Range(0, provences.Length);
            }
            planes[ranPlane].GetComponent<PlaneMovement>().hit = false;
            planes[ranPlane].GetComponent<PlaneMovement>().provence = provences[ranProvence];
            planes[ranPlane].GetComponent<PlaneClick>().provence = provences[ranProvence];
            planes[ranPlane].GetComponent<PlaneMovement>().inFlight = true;
            if(Random.Range(0, 4) == 0)
            {
                planes[ranPlane].GetComponent<PlaneMovement>().nice = false;
            }
            else
            {
                planes[ranPlane].GetComponent<PlaneMovement>().nice = true;
            }
            planesInAir ++;
        }

        if(Input.GetKeyDown("l") && (planesInAir != planes.Length))
        {
            Debug.Log("Click");
            int ranPlane = Random.Range(0, planes.Length);
            int ranProvence = Random.Range(0, provences.Length);
            while(planes[ranPlane].GetComponent<PlaneMovement>().inFlight == true)
            {
                ranPlane = Random.Range(0, planes.Length);
            }
            while((planes[ranPlane].transform.position.x, planes[ranPlane].transform.position.y) == (provences[ranProvence].transform.position.x, provences[ranProvence].transform.position.y))
            {
                ranProvence = Random.Range(0, provences.Length);
            }
            planes[ranPlane].GetComponent<PlaneMovement>().provence = provences[ranProvence];
            planes[ranPlane].GetComponent<PlaneClick>().provence = provences[ranProvence];
            planes[ranPlane].GetComponent<PlaneMovement>().inFlight = true;
            if(Random.Range(0, 4) == 0)
            {
                planes[ranPlane].GetComponent<PlaneMovement>().nice = false;
            }
            else
            {
                planes[ranPlane].GetComponent<PlaneMovement>().nice = true;
            }
            planesInAir ++;
        }
    }
}
