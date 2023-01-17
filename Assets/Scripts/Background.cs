using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material bgMaterial; //��� material
    public float scrollSpeed = 0.2f; //��ũ�� �ӵ�

    void Start()
    {
        
    }

    //����ִ� ���� ����̴ϱ� Update()�� �ۼ�
    void Update()
    {
        Vector2 direction = Vector2.up; //����: ��
        bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime; //��ũ�� �Ѵ�
    }
}
