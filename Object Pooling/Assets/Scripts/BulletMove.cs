using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.tag == "Enemy")
        {
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);

            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 5f * Time.deltaTime);
    }
}
