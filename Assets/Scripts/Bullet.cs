using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5; //�Ѿ��� �߻�Ǵ� �ӵ�

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 dir = Vector3.up; //�Ѿ��� �߻�Ǵ� ����: ��
        transform.position += dir * speed * Time.deltaTime; //�Ѿ��� �̵��Ѵ�.
    }
}
