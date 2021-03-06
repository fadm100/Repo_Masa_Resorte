using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ControlTexto : MonoBehaviour {
    public Button Incremento;
    public Button Decremento;
    private Text miTexto;
    public static float mass = 1.0f;
    private float inc = 1.0f;

    void Start () {
        Button btnIn = Incremento.GetComponent<Button>();
        btnIn.onClick.AddListener(TaskOnClickIn);
        
        Button btnDe = Decremento.GetComponent<Button>();
        btnDe.onClick.AddListener(TaskOnClickDe);
        
        miTexto = GetComponent<Text>();
        miTexto.text = "Masa = " + mass;
    }

    void TaskOnClickIn(){
        //Debug.Log ("You have clicked the button!");
        
        if (mass<10.0f)
        {
            mass = mass + inc;
            double b;
            b = System.Math.Round(mass,2);
            miTexto.text = "Masa = " + b;
        }
        else
        {
            mass = 10f;
            miTexto.text = "Masa = " + mass;
        }
    }
    
    void TaskOnClickDe(){
        //Debug.Log ("You have clicked the button!");
        
        if (mass>1.0f)
        {
            mass = mass - inc;
            double b;
            b = System.Math.Round(mass,2);
            miTexto.text = "Masa = " + b;
        }
        else
        {
            mass = 1.0f;
            miTexto.text = "Masa = " + mass;
        }
    }
}