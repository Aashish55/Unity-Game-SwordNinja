using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class knife : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed;
    private Rigidbody2D rigidbody2D;

    private Vector2 direction;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>(); 
        
    }
    void FixedUpdate(){
        rigidbody2D.velocity =direction*speed;
    }
    void OnBecameInvisible() {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("mainGround")){
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("enemyPlayer"))
        {
            enemyController.enemyLife1 -= 0.1f;
            if (enemyController.enemyLife1< 0)
            {
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
        }
        else if(other.gameObject.CompareTag("enemyplayer2")){
            enemyController.enemyLife2-= 0.1f;
            if (enemyController.enemyLife2 < 0)
            {
                Destroy(other.gameObject);    
            }
            Destroy(gameObject);
            
        }
        else if(other.gameObject.CompareTag("enemyplayer3")){
            enemyController.enemyLife3-= 0.1f;
            if (enemyController.enemyLife3 < 0)
            {
                Destroy(other.gameObject);    
            }
            Destroy(gameObject);
            
        }
        else if(other.gameObject.CompareTag("enemyplayer4")){
            enemyController.enemyLife4-= 0.1f;
            if (enemyController.enemyLife4 < 0)
            {
                Destroy(other.gameObject);    
            }
            Destroy(gameObject);
            
        }
        else if(other.gameObject.CompareTag("enemyplayer5")){
            enemyController.enemyLife5-= 0.1f;
            if (enemyController.enemyLife5 < 0)
            {
                Destroy(other.gameObject);    
            }
            Destroy(gameObject);
            
        }
        else if(other.gameObject.CompareTag("enemyplayer6")){
            enemyController.enemyLife6-= 0.1f;
            if (enemyController.enemyLife6 < 0)
            {
                Destroy(other.gameObject);    
            }
            Destroy(gameObject);
            
        }
        else if(other.gameObject.CompareTag("enemyplayer7")){
            enemyController.enemyLife7-= 0.1f;
            if (enemyController.enemyLife7 < 0)
            {
                Destroy(other.gameObject);    
            }
            Destroy(gameObject);
            
        }
        else if(other.gameObject.CompareTag("enemyplayer8")){
            enemyController.enemyLife8-= 0.1f;
            if (enemyController.enemyLife8 < 0)
            {
                Destroy(other.gameObject);    
            }
            Destroy(gameObject);
            
        }
        else if(other.gameObject.CompareTag("enemyplayer9")){
            enemyController.enemyLife9-= 0.1f;
            if (enemyController.enemyLife9 < 0)
            {
                Destroy(other.gameObject);    
            }
            Destroy(gameObject);
            
        }
        else if(other.gameObject.CompareTag("enemyplayer10")){
            enemyController.enemyLife10-= 0.1f;
            if (enemyController.enemyLife10 < 0)
            {
                Destroy(other.gameObject);    
            }
            Destroy(gameObject);
            
        }
    }
    public void Initialize(Vector2 direction){
        this.direction=direction;
    }
    // Update is called once per frame
}
