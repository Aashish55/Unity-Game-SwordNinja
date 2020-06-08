using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class NinjaController : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    Animator animator;
    Rigidbody2D rb2d;
    public Joystick joystick;
    public static bool attackButtonPressed = false;
    bool throwButtonPressed = false;
    SpriteRenderer spriteRenderer;
    bool facingRight = true;
    private float runspeed = 6f;
    private float jumpspeed = 6f;
    [SerializeField] private GameObject knife;
    private BoxCollider2D boxCollider2d;
    public static bool ninjaCollision = false;
    public static float playerHealth = 1;
    public Image healthImage;
    public float time = 0;
    public TextMeshProUGUI coinScore;
    public static bool newGame=true;
    public static int kills=0;

    public static string enemyName;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2d = GetComponent<BoxCollider2D>();
    }

    private bool isGrounded()
    {
        float extraHeightText = .5f;
        RaycastHit2D raycastHit = Physics2D.Raycast(boxCollider2d.bounds.center, Vector2.down, boxCollider2d.bounds.extents.y + extraHeightText, platformLayerMask);
        Color rayColor;
        if (raycastHit.collider != null)
        {
            rayColor = Color.green;

        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(boxCollider2d.bounds.center, Vector2.down * (boxCollider2d.bounds.extents.y + extraHeightText));
        //return raycastHit.collider!=null;

        if (raycastHit.collider != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public void onAttackButtonClicked()
    {
        if (isGrounded())
        {
            if (ninjaCollision == true && enemyName == "enemy1")
            {
                enemyController.enemyLife1 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy2")
            {
                enemyController.enemyLife2 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy3")
            {
                enemyController.enemyLife3 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy4")
            {
                enemyController.enemyLife4 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy5")
            {
                enemyController.enemyLife5 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy6")
            {
                enemyController.enemyLife6 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy7")
            {
                enemyController.enemyLife7 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy8")
            {
                enemyController.enemyLife8 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy9")
            {
                enemyController.enemyLife9 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy10")
            {
                enemyController.enemyLife10 -= .4f;
            }
            animator.Play("attack");
        }
        else if (!isGrounded())
        {
            if (ninjaCollision == true && enemyName == "enemy1")
            {
                enemyController.enemyLife1 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy2")
            {
                enemyController.enemyLife2 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy3")
            {
                enemyController.enemyLife3 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy4")
            {
                enemyController.enemyLife4 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy5")
            {
                enemyController.enemyLife5 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy6")
            {
                enemyController.enemyLife6 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy7")
            {
                enemyController.enemyLife7 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy8")
            {
                enemyController.enemyLife8 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy9")
            {
                enemyController.enemyLife9 -= .4f;
            }
            else if (ninjaCollision == true && enemyName == "enemy10")
            {
                enemyController.enemyLife10 -= .4f;
            }
            animator.Play("jumpAttack");

        }

        attackButtonPressed = true;
    }
    public void onThrowButtonClicked()
    {

        if (isGrounded())
        {
            animator.Play("throw");
        }
        else if (!isGrounded())
        {
            animator.Play("jumpThrow");
        }
        throwKnife(0);
        throwButtonPressed = true;
    }
    public void throwKnife(int value)
    {
        if (facingRight)
        {
            GameObject tmp = (GameObject)Instantiate(knife, transform.position + new Vector3(2, 0, 0), Quaternion.Euler(new Vector3(0, 0, -90)));
            tmp.GetComponent<knife>().Initialize(Vector2.right);
        }
        else
        {
            GameObject tmp = (GameObject)Instantiate(knife, transform.position + new Vector3(-2, 0, 0), Quaternion.Euler(new Vector3(0, 0, 90)));
            tmp.GetComponent<knife>().Initialize(Vector2.left);
        }


    }

    private void FixedUpdate()
    {

        if(enemyController.enemyLife1<0){
                ninjaCollision=false;
                enemyController.enemyLife1=0;
                kills++;
        }
        else if(enemyController.enemyLife2<0){
                ninjaCollision=false;
                enemyController.enemyLife2=0;
                kills++;
        }
        else if(enemyController.enemyLife3<0){
                ninjaCollision=false;
                enemyController.enemyLife3=0;
                kills++;
        }
        else if(enemyController.enemyLife4<0){
                ninjaCollision=false;
                enemyController.enemyLife4=0;
                kills++;
        }
        else if(enemyController.enemyLife5<0){
                ninjaCollision=false;
                enemyController.enemyLife5=0;
                kills++;
        }
        else if(enemyController.enemyLife6<0){
                ninjaCollision=false;
                enemyController.enemyLife6=0;
                kills++;
        }
        else if(enemyController.enemyLife7<0){
                ninjaCollision=false;
                enemyController.enemyLife7=0;
                kills++;
        }
        else if(enemyController.enemyLife8<0){
                ninjaCollision=false;
                enemyController.enemyLife8=0;
                kills++;
        }
        else if(enemyController.enemyLife9<0){
                ninjaCollision=false;
                enemyController.enemyLife9=0;
                kills++;
        }
        else if(enemyController.enemyLife10<0){
                ninjaCollision=false;
                enemyController.enemyLife10=0;
                kills++;
        }

        if (ninjaCollision == true)
        {
            playerHealth -= Time.deltaTime / 5;
        }
        if (playerHealth < 0)
        {
            playerHealth = 0;
            SceneManager.LoadScene("gameoverScene");
        }
        
        healthImage.fillAmount = playerHealth;


        if (joystick.Horizontal < -.2f && joystick.Vertical > .2f && isGrounded())
        {
            rb2d.velocity = new Vector2(-runspeed, jumpspeed);
            spriteRenderer.flipX = true;
            facingRight = false;
            animator.Play("Jump");
            attackButtonPressed = false;
            throwButtonPressed = false;

        }
        else if (joystick.Horizontal > .2f && joystick.Vertical > .2f && isGrounded())
        {
            rb2d.velocity = new Vector2(runspeed, jumpspeed);
            spriteRenderer.flipX = false;
            facingRight = true;
            animator.Play("Jump");
            attackButtonPressed = false;
            throwButtonPressed = false;

        }
        else if (joystick.Vertical > .2f && isGrounded())
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpspeed);
            animator.Play("Jump");
            attackButtonPressed = false;
            facingRight = true;
            throwButtonPressed = false;

        }
        else if (joystick.Horizontal > .2f)
        {
            rb2d.velocity = new Vector2(runspeed, rb2d.velocity.y);
            if (isGrounded())
            {
                animator.Play("Run");
            }
            else if (isGrounded() && Input.GetKeyDown("space"))
            {
                animator.Play("attack");
            }
            spriteRenderer.flipX = false;
            facingRight = true;
            attackButtonPressed = false;
            throwButtonPressed = false;

        }
        else if (joystick.Horizontal < -.2f)
        {
            rb2d.velocity = new Vector2(-runspeed, rb2d.velocity.y);
            if (isGrounded())
            {
                animator.Play("Run");
            }
            else if (isGrounded() && Input.GetKeyDown("space"))
            {
                animator.Play("attack");
            }
            spriteRenderer.flipX = true;
            facingRight = false;
            attackButtonPressed = false;
            throwButtonPressed = false;

        }
        else if (joystick.Vertical < -.2f && joystick.Horizontal > .2f && isGrounded())
        {
            animator.Play("slide");
            rb2d.velocity = new Vector2(5f, -jumpspeed);
            attackButtonPressed = false;
            throwButtonPressed = false;
            facingRight = true;
        }
        else if (joystick.Vertical < -.2f && joystick.Horizontal < -.2f && isGrounded())
        {
            animator.Play("slide");
            rb2d.velocity = new Vector2(-5f, -jumpspeed);
            attackButtonPressed = false;
            throwButtonPressed = false;
            facingRight = false;
        }
        else if (joystick.Vertical < -.2f && isGrounded())
        {
            animator.Play("slide");
            attackButtonPressed = false;
            throwButtonPressed = false;
            facingRight = true;

        }
        else if (isGrounded() && !attackButtonPressed && !throwButtonPressed)
        {

            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            animator.Play("Idle");

        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemyPlayer"))
        {
            ninjaCollision = true;
            enemyName = "enemy1";
            
        }
        else if (other.gameObject.CompareTag("enemyplayer2"))
        {
            ninjaCollision = true;
            enemyName = "enemy2";
            
        }
        else if (other.gameObject.CompareTag("enemyplayer3"))
        {
            ninjaCollision = true;
            enemyName = "enemy3";
            
        }
        else if (other.gameObject.CompareTag("enemyplayer4"))
        {
            ninjaCollision = true;
            enemyName = "enemy4";
            
        }
        else if (other.gameObject.CompareTag("enemyplayer5"))
        {
            ninjaCollision = true;
            enemyName = "enemy5";
            
        }
        else if (other.gameObject.CompareTag("enemyplayer6"))
        {
            ninjaCollision = true;
            enemyName = "enemy6";
            
        }
        else if (other.gameObject.CompareTag("enemyplayer7"))
        {
            ninjaCollision = true;
            enemyName = "enemy7";
            
        }
        else if (other.gameObject.CompareTag("enemyplayer8"))
        {
            ninjaCollision = true;
            enemyName = "enemy8";
            
        }
        else if (other.gameObject.CompareTag("enemyplayer9"))
        {
            ninjaCollision = true;
            enemyName = "enemy9";
            
        }
        else if (other.gameObject.CompareTag("enemyplayer10"))
        {
            ninjaCollision = true;
            enemyName = "enemy10";
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("goldCoin"))
        {
            //newGame=false;
            ScoreManager.instance.ChangeScore(10);
            Destroy(other.gameObject);
            

        }
        if (other.gameObject.CompareTag("silverCoin"))
        {
            //newGame=false;
            ScoreManager.instance.ChangeScore(5);
            Destroy(other.gameObject);
            

        }
        if (other.gameObject.CompareTag("copperCoin"))
        {
            //newGame=false;
            ScoreManager.instance.ChangeScore(2);
            Destroy(other.gameObject);
            

        }
        if (other.gameObject.CompareTag("loosecolliderright"))
        {
            SceneManager.LoadScene("levelcompletedScene");

        }
    }

}