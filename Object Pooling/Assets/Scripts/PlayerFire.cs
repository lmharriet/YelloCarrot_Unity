using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            //GetPooledObject로 bullet의 정보를 받아온 후 bullet에 할당

            //GameObject bullet = ObjectPooler.SharedInstance.GetPooledObject();
            GameObject bullet = ObjectPooler_Expand.SharedInstance.GetPooledObject("Player Bullet");
            

            //bullet이 null로 리턴된 경우는 아까 설명함.

            //고로 null이 아니면 제대로 object가 리턴됬다는 의미
            if(bullet != null)
            {
                //bullet의 위치 및 회전값을 플레이어의 위치 및 회전값으로 변경 
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;

                //이제 발사할 준비를 마쳤으니 오브젝트를 활성화 해줌
                bullet.SetActive(true);
            }
        }
    }
}
