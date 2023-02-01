using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 dir;
    public float speed = 5; //�̵� �ӵ�
    public GameObject explosionFactory; //���� ȿ�� ����

    void Start()
    {
        int randValue = UnityEngine.Random.Range(0, 10); //0~10 ������ ����

        //�������� 3���� ������ �÷��̾� ����
        if(randValue < 3)
        {
            GameObject target = GameObject.Find("Player"); //�÷��̾ ã�� Ÿ������ ����
            dir = target.transform.position - transform.position; //������ ���� ����
            dir.Normalize(); //������ ũ�⸦ 1��
        }

        //�������� 3���� ũ�� �Ʒ� ����
        else
        {
            dir = Vector3.down;
        }
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime; //�̵�
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject explosion = Instantiate(explosionFactory); //���忡�� ȿ�� �ϳ� ����
        explosion.transform.position = transform.position; //���� ȿ���� ��ġ��Ų��

        Destroy(other.gameObject); //���� �ε��� ��ü �ı�
        Destroy(gameObject); //�� ��ü �ı�

        //���� ���� ǥ��
        GameObject smObject = GameObject.Find("ScoreManager"); //������ ScoreManager ��ü�� ã�ƿ´�
        ScoreManager sm = smObject.GetComponent<ScoreManager>(); //ScoreManager ���� ������Ʈ���� ���´�.
        
        sm.SetScore(sm.GetScore() + 1);
    }
}
