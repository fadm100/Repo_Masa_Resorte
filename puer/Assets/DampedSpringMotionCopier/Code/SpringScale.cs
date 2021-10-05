using System.Collections;
using System.Collections.Generic;
using PhysicalWalk;
using UnityEngine;

public class SpringScale : MonoBehaviour
{
    // Start is called before the first frame update
    //public DampedSpringMotionCopier pos;
    private DampedSpringMotionCopier pos;

    private Vector3 _actual = new Vector3(5.0f , 4.0f , 5.0f);
    //public partial PositionalSpringTweaksAndState position;
    //public ControlTeclado position;
    
    void Start()
    {
        //pos = FindObjectOfType<DampedSpringMotionCopier>();
        //Debug.Log("la posición que quiero es " + pos.delta);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale = MotionTarget.transform.position,
        pos = FindObjectOfType<DampedSpringMotionCopier>();
        //_actual = transform.lossyScale;
        //Debug.Log("la escala actual es " + actual);
        var transformLocalScale = transform.localScale;
        transformLocalScale.y = _actual.y + pos.delta.z*4;
        transform.localScale = transformLocalScale;
        //Debug.Log("la posición que quiero es " + pos.delta);

    }
}
