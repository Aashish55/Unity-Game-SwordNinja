using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyController : MonoBehaviour
{
    [SerializeField]
    private Transform ninja;
    private float distance;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigidbody2d;
    private float runspeed = 6f;
    private float jumpspeed = 6f;
    public static float enemyLife1 = 1;
    public static float enemyLife2 = 1;
    public static float enemyLife3 = 1;
    public static float enemyLife4 = 1;
    public static float enemyLife5 = 1;
    public static float enemyLife6 = 1;
    public static float enemyLife7 = 1;
    public static float enemyLife8 = 1;
    public static float enemyLife9 = 1;
    public static float enemyLife10 = 1;

    private GameObject EnemyNumber1;
    private GameObject EnemyNumber2;
    private GameObject EnemyNumber3;
    private GameObject EnemyNumber4;
    private GameObject EnemyNumber5;
    private GameObject EnemyNumber6;
    private GameObject EnemyNumber7;
    private GameObject EnemyNumber8;
    private GameObject EnemyNumber9;
    private GameObject EnemyNumber10;
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody2d = GetComponent<Rigidbody2D>();

        EnemyNumber1=GameObject.FindWithTag("enemyPlayer");
        EnemyNumber2=GameObject.FindWithTag("enemyplayer2");
        EnemyNumber3=GameObject.FindWithTag("enemyplayer3");
        EnemyNumber4=GameObject.FindWithTag("enemyplayer4");
        EnemyNumber5=GameObject.FindWithTag("enemyplayer5");
        EnemyNumber6=GameObject.FindWithTag("enemyplayer6");
        EnemyNumber7=GameObject.FindWithTag("enemyplayer7");
        EnemyNumber8=GameObject.FindWithTag("enemyplayer8");
        EnemyNumber9=GameObject.FindWithTag("enemyplayer9");
        EnemyNumber10=GameObject.FindWithTag("enemyplayer10");

        
    }

    private void Update()
    {
        if(enemyLife1<0){
            Destroy(EnemyNumber1);
        }else if(enemyLife2<0){
            Destroy(EnemyNumber2);
        }else if(enemyLife3<0){
            Destroy(EnemyNumber3);
        }else if(enemyLife4<0){
            Destroy(EnemyNumber4);
        }else if(enemyLife5<0){
            Destroy(EnemyNumber5);
        }else if(enemyLife6<0){
            Destroy(EnemyNumber6);
        }else if(enemyLife7<0){
            Destroy(EnemyNumber7);
        }else if(enemyLife8<0){
            Destroy(EnemyNumber8);
        }else if(enemyLife9<0){
            Destroy(EnemyNumber9);
        }else if(enemyLife10<0){
            Destroy(EnemyNumber10);
        }


        if (NinjaController.playerHealth < 0)
        {
            distance = 9;
        }
        else
        {
            distance = ninja.transform.position.x - transform.position.x;
        }




        if (distance < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }





        if (distance < 1.2 && distance > -1.5)
        {
            animator.Play("swordattack");
            NinjaController.ninjaCollision=true;
            
        }
        else if (distance >= -8 && distance <= -1.2)
        {
            animator.Play("enemyrun");
            rigidbody2d.velocity = new Vector2(-runspeed, rigidbody2d.velocity.y);
            NinjaController.ninjaCollision=false;
        }
        else if (distance <= 8 && distance >= 1.2)
        {
            animator.Play("enemyrun");
            rigidbody2d.velocity = new Vector2(runspeed, rigidbody2d.velocity.y);
            NinjaController.ninjaCollision=false;
        }
        else
        {
            animator.Play("enemyidle");
        }

    }
}
