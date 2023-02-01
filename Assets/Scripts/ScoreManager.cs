using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text currentScoreUI; //���� ���� UI
    private int currentScore; //���� ����

    public Text bestScoreUI; //�ְ� ���� UI
    private int bestScore; //�ְ� ����

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0); //�ְ� ������ �ҷ��� bestScore�� �Ҵ�
        bestScoreUI.text = "�ְ� ����: " + bestScore;
    }

    void Update()
    {
        
    }

    //currentScore�� ���� �ְ� ȭ�鿡 ǥ��
    public void SetScore(int value)
    {
        currentScore = value; //�޾ƿ� ���� currentScore�� �Ҵ�
        currentScoreUI.text = "���� ����: " + currentScore; //ȭ�鿡 ���� ���� ǥ��

        //���� ���� ������ �ְ� �������� Ŀ����
        if(currentScore > bestScore)
        {
            bestScore = currentScore; //�ְ� ���� ����
            bestScoreUI.text = "�ְ� ����: " + bestScore; //ȭ�鿡 �ְ� ���� ǥ��
            PlayerPrefs.SetInt("Best Score", bestScore); //�ְ� ���� ����. SetInt()
        }
    }

    //currentScore �� ��������
    public int GetScore()
    {
        return currentScore;
    }
}
