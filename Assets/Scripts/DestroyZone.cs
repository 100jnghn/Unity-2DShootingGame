using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //���� �ȿ� �ٸ� ��ü�� �����Ǹ�
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); //�ش� ��ü�� ���ش�.
    }
}
