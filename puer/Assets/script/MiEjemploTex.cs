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

        float zita = dats.positionalSpring.dampingCriticality;
        float wn = dats.positionalSpring.naturalFrequency.z;
        float num1 = wn*wn, num2 = 2*zita*wn;
        string formula1 = string.Format( @"\zeta{0}={0}{1}{2}", "\n", zita, Environment.NewLine); // Environment.NewLine hace el salto de linea pero también es necesario poner "\n\r" en la sección donde se imprime
        string formula2 = string.Format( @"w_n{0}={0}{1}{2}", "\n", wn, Environment.NewLine);
        string formula = string.Format( @"TF:{3} G(s)=\frac{{{0}}}{{s^2+{1}s+{2}}}", num1, num2, num1, "\n");
        output.text = formula1 + "\n\r" + formula2 + "\n\r" + formula;
        //string formula = string.Format( @"\zeta={1}{0} TF:{5} G(s)=\frac{{{2}}}{{s^2+{3}s+{4}}}", Environment.NewLine, zita, num1, num2, num1, "\n");
        //output.text = formula;
        //Debug.Log("El valor de zita es " + dats.dampingCriticality);
        //Debug.Log("El valor de wn es " + dats.naturalFrequency.z);
    }
}
