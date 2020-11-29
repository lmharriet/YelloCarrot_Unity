using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemPrefab;
    public Transform strPoint, endPoint;

    public float endCount;
    float curCount = 0;

    // Update is called once per frame
    void Update()
    {
        curCount += Time.deltaTime;

        if(curCount > endCount)
        {
            curCount = 0;

            //생성
            //Instantiate(enemPrefab, RandomPos(), Quaternion.identity);
            GameObject enem = ObjectPooler_Expand.SharedInstance.GetPooledObject("Enemy");
            enem.transform.position = RandomPos();
            enem.transform.rotation = Quaternion.identity;

            enem.SetActive(true);
        }
    }

    Vector3 RandomPos()
    {
        //랜덤

        //x만 랜덤으로 하고, y랑 z는 둘다 똑같음
        Vector3 ranPos = strPoint.position;
        ranPos.x = Random.Range(strPoint.position.x, endPoint.position.x);

        return ranPos;
    }
}
