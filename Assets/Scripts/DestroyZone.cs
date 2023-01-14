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

    //영역 안에 다른 물체가 감지되면
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); //해당 물체를 없앤다.
    }
}
