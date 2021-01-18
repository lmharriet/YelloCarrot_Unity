using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    Vector3 defaultPos;
    public Transform endPos;

    public float speed = 1.5f;
    public bool moveRight = true;

    public bool isLock = false;

    public GameObject Number;

    public void changeLock(float sec)
    {
        if (isLock) return;

        StartCoroutine(waitsec(sec));
    }

    IEnumerator waitsec(float sec)
    {
        Number.SetActive(true);
        isLock = true;
        yield return new WaitForSeconds(sec);
        isLock = false;
        Number.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        defaultPos = transform.position;
        Number.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isLock) return;

        if(moveRight)
        {
            transform.position = Vector3.Lerp(transform.position, endPos.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, endPos.position) < 0.5f) 
                moveRight = false;
        }

        else
        {
            transform.position = Vector3.Lerp(transform.position, defaultPos, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, defaultPos) < 0.5f)
                moveRight = true;
        }
    }
}
