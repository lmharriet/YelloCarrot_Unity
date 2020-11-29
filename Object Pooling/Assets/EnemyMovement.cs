using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        StartCoroutine(coru());
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    
    IEnumerator coru()
    {
        yield return new WaitForSeconds(10f);
        gameObject.SetActive(false);
    }
}
