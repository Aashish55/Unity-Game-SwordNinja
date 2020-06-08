using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playAgain : MonoBehaviour
{
    public void returnToMainMenu(){
        SceneManager.LoadScene("MenuScene");
        
    }
   
}
