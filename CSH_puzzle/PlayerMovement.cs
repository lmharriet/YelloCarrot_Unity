using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rigid;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MoveGround") transform.parent = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "MoveGround") transform.parent = null;
    }

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Controller();

        Jump();
    }

    private void Controller()
    {
        float h = Input.GetAxis("Horizontal") * speed;
        float v = Input.GetAxis("Vertical") * speed;

        transform.Translate(new Vector3(h * Time.deltaTime, 0, v * Time.deltaTime));
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(new Vector3(0, 200f, 0));
        }
    }
}
