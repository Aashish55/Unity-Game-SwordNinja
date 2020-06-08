using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killManager : MonoBehaviour
{
    public static killManager instance;
    public Text text;


    void Start() {
        if(instance==null){
            instance=this;
        }     
    }

    private void Update() {
        text.text="Kills: "+NinjaController.kills.ToString();
    }
}
