using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameoverKills : MonoBehaviour
{
   public static gameoverKills instance;
    public TextMeshProUGUI text;


    void Start() {
        if(instance==null){
            instance=this;
        }     
    }

    private void Update() {
        text.text="Kills: "+NinjaController.kills.ToString();
    }
}
