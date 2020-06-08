using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class gameoverScore : MonoBehaviour
{   
    public static gameoverScore instance;
    public TextMeshProUGUI text;


    void Start() {
        if(instance==null){
            instance=this;
        }     
    }

    private void Update() {
        text.text="Score: "+ScoreManager.amount.ToString();
    }
}
