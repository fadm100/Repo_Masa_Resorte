using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MiEjemploTex : MonoBehaviour
{
    public TEXDraw output;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int num1 = 100, num2 = 2, num3 = 100;
        //string formula = string.Format( @"Solve: \sin({0})+\root{{\frac{{{1}}}{{{2}}}", num1, num2, num3);
        string formula = string.Format( @"TF:{3} G(s)=\frac{{{0}}}{{s^2+{1}s+{2}}}", num1, num2, num3, "\n");
        output.text = formula;
    }
}
