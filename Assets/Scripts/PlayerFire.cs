using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory; //�Ѿ� ���� ����
    public GameObject firePosition;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //�Ѿ� �߻� ��ư�� ������
        {
            GameObject bullet = Instantiate(bulletFactory); //���忡�� �Ѿ��� �����ϰ�
            bullet.transform.position = firePosition.transform.position; //�Ѿ��� �ѱ��� ������ ���� �߻��Ѵ�.
        }
    }
}
