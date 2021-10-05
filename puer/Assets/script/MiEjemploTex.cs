using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using PhysicalWalk;

public class MiEjemploTex : MonoBehaviour
{
    public TEXDraw output;
    private DampedSpringMotionCopier dats;
    //private Vector3 naturalFrequency;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dats = FindObjectOfType<DampedSpringMotionCopier>();

        float zita = dats.dampingCriticality;
        float wn = dats.naturalFrequency.z;
        float num1 = wn*wn, num2 = 2*zita*wn;
        //string formula = string.Format( @"Solve: \sin({0})+\root{{\frac{{{1}}}{{{2}}}", num1, num2, num3);
        string formula = string.Format( @"TF:{3} G(s)=\frac{{{0}}}{{s^2+{1}s+{2}}}", num1, num2, num1, "\n");
        output.text = formula;
        //Debug.Log("El valor de zita es " + dats.dampingCriticality);
        //Debug.Log("El valor de wn es " + dats.naturalFrequency.z);
    }
}
