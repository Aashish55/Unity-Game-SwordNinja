using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar8 : MonoBehaviour
{
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }
    void Update()
    {
        localScale.x = enemyController.enemyLife8;
        if(localScale.x <0){
            localScale.x=0;
        }
        transform.localScale = localScale;
    }
}
