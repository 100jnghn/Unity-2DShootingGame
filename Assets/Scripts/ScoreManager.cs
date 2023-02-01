using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text currentScoreUI; //현재 점수 UI
    private int currentScore; //현재 점수

    public Text bestScoreUI; //최고 점수 UI
    private int bestScore; //최고 점수

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0); //최고 점수를 불러와 bestScore에 할당
        bestScoreUI.text = "최고 점수: " + bestScore;
    }

    void Update()
    {
        
    }

    //currentScore에 값을 넣고 화면에 표시
    public void SetScore(int value)
    {
        currentScore = value; //받아온 값을 currentScore에 할당
        currentScoreUI.text = "현재 점수: " + currentScore; //화면에 현재 점수 표시

        //만약 현재 점수가 최고 점수보다 커지면
        if(currentScore > bestScore)
        {
            bestScore = currentScore; //최고 점수 갱신
            bestScoreUI.text = "최고 점수: " + bestScore; //화면에 최고 점수 표시
            PlayerPrefs.SetInt("Best Score", bestScore); //최고 점수 저장. SetInt()
        }
    }

    //currentScore 값 가져오기
    public int GetScore()
    {
        return currentScore;
    }
}
