using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5; //총알이 발사되는 속도

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 dir = Vector3.up; //총알이 발사되는 방향: 위
        transform.position += dir * speed * Time.deltaTime; //총알이 이동한다.
    }
}
