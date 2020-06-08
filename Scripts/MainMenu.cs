using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("level02");
        NinjaController.kills=0;
        Time.timeScale=1f;
        NinjaController.playerHealth=1;
        NinjaController.ninjaCollision=false;
        NinjaController.newGame=true;
        enemyController.enemyLife1=1;
        enemyController.enemyLife2=1;
        enemyController.enemyLife3=1;
        enemyController.enemyLife4=1;
        enemyController.enemyLife5=1;
        enemyController.enemyLife6=1;
        
    }
    public void QuitGame(){
        Application.Quit();
    }
}
