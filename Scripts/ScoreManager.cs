using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public static int amount=0;
    public TextMeshProUGUI text;


    void Start() {
        if(instance==null){
            instance=this;
        }     
    }

    public void ChangeScore(int coinValue){
        if(NinjaController.newGame==true){
            amount=coinValue;
            text.text=amount.ToString();
            NinjaController.newGame=false;
        }else{
            amount+= coinValue;
        text.text=amount.ToString();
        }
        
        
    }
}
