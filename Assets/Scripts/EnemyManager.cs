using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float currentTime; //현재 시간
    public float createTime = 1; //일정 시간
    public GameObject enemyFactory; //적 공장

    float minTime = 1; //최소 시간
    float maxTime = 5; //최대 시간

    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime); //적 생성 시간 설정
    }

    void Update()
    {
        currentTime += Time.deltaTime; //시간이 얼마나 흘렀는가 계산

        //일정 시간이 흐르면
        if (currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyFactory); //적 공장에서 적 생성
            enemy.transform.position = transform.position; //위치 시킨다.

            currentTime = 0; //현재 시간 초기화
            createTime = UnityEngine.Random.Range(minTime, maxTime); //적 생성 시간 재설정
        }
    }
}
