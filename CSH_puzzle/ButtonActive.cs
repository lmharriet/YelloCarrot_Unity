using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActive : MonoBehaviour
{
    public GameObject Floor;

    public float lockTime;

    public float maxTime;
    float curTime;

    bool isActive = false;  

    private void OnTriggerEnter(Collider other)
    {
        if(isActive == false && other.tag == "Player")
        {
            isActive = true;

            Floor.GetComponent<GroundMovement>().changeLock(lockTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive)
        {
            curTime += Time.deltaTime;

            if (curTime > lockTime) isActive = false;
        }
    }
}
