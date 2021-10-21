using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ControlTextoK : MonoBehaviour {
    public Button Incremento;
    public Button Decremento;
    private Text miTexto;
    public static int k = 100;
    private int inc = 100;

    void Start () {
        Button btnIn = Incremento.GetComponent<Button>();
        btnIn.onClick.AddListener(TaskOnClickIn);
        
        Button btnDe = Decremento.GetComponent<Button>();
        btnDe.onClick.AddListener(TaskOnClickDe);
        
        miTexto = GetComponent<Text>();
        miTexto.text = "k = " + k;
    }

    void TaskOnClickIn(){
        //Debug.Log ("You have clicked the button!");
        
        if (k<1000)
        {
            k = k + inc;
            miTexto.text = "k = " + k;
            
        }
        else
        {
            k = 1000;
            miTexto.text = "k = " + k;
        }
    }
    
    void TaskOnClickDe(){
        //Debug.Log ("You have clicked the button!");
        
        if (k>100)
        {
            k = k - inc;
            miTexto.text = "k = " + k;
            
        }
        else
        {
            k = 100;
            miTexto.text = "k = " + k;
        }
    }
}