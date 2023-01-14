using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float currentTime; //���� �ð�
    public float createTime = 1; //���� �ð�
    public GameObject enemyFactory; //�� ����

    float minTime = 1; //�ּ� �ð�
    float maxTime = 5; //�ִ� �ð�

    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime); //�� ���� �ð� ����
    }

    void Update()
    {
        currentTime += Time.deltaTime; //�ð��� �󸶳� �귶�°� ���

        //���� �ð��� �帣��
        if (currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyFactory); //�� ���忡�� �� ����
            enemy.transform.position = transform.position; //��ġ ��Ų��.

            currentTime = 0; //���� �ð� �ʱ�ȭ
            createTime = UnityEngine.Random.Range(minTime, maxTime); //�� ���� �ð� �缳��
        }
    }
}
