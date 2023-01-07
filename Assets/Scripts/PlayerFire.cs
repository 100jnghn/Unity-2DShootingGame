using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory; //총알 생산 공장
    public GameObject firePosition;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //총알 발사 버튼을 누르면
        {
            GameObject bullet = Instantiate(bulletFactory); //공장에서 총알을 생성하고
            bullet.transform.position = firePosition.transform.position; //총알을 총구에 가져다 놓고 발사한다.
        }
    }
}
