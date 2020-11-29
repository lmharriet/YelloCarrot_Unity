using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        //충돌한 대상이 Boundary tag 일 때
        if(other.gameObject.tag == "Boundary")
        {
            //현재 Object tag가 Player Bullet일 때!
            if (gameObject.tag == "Player Bullet")
            {
                //오브젝트 풀을 적용시켰으니 Active
                gameObject.SetActive(false);
            }

            //만약 Object tag가 다른거면 그냥 삭제!
            else Destroy(gameObject);
        }
    }
}
