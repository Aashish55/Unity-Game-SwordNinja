using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar2 : MonoBehaviour
{
   Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }
    void Update()
    {
        localScale.x = enemyController.enemyLife2;
        if(localScale.x <0){
            localScale.x=0;
        }
        transform.localScale = localScale;
    }
}
