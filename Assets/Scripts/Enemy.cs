using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 dir;
    public float speed = 5; //이동 속도

    void Start()
    {
        int randValue = UnityEngine.Random.Range(0, 10); //0~10 랜덤값 생성

        //랜덤값이 3보다 작으면 플레이어 방향
        if(randValue < 3)
        {
            GameObject target = GameObject.Find("Player"); //플레이어를 찾아 타겟으로 설정
            dir = target.transform.position - transform.position; //가야할 방향 설정
            dir.Normalize(); //방향의 크기를 1로
        }

        //랜덤값이 3보다 크면 아래 방향
        else
        {
            dir = Vector3.down;
        }
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime; //이동
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject); //나와 부딪힌 객체 파괴
        Destroy(gameObject); //이 객체 파괴
    }
}
