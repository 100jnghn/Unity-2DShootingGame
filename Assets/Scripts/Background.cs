using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material bgMaterial; //배경 material
    public float scrollSpeed = 0.2f; //스크롤 속도

    void Start()
    {
        
    }

    //살아있는 동안 계속이니까 Update()에 작성
    void Update()
    {
        Vector2 direction = Vector2.up; //방향: 위
        bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime; //스크롤 한다
    }
}
