using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class pauseSceneLoader : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;

    public void pauseMenu()
    {
        gameIsPaused = true;
        if (gameIsPaused == true)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    public void returnToGame(){
        gameIsPaused=false;
        if (gameIsPaused == true)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    public void goToMenu(){
        SceneManager.LoadScene("MenuScene");
        
    }
    public void quit(){
        Application.Quit();
    }
}
