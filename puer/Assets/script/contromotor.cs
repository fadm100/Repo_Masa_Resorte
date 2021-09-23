using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contromotor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("0"))
        {
            transform.Rotate(new Vector3(0f, 0f, 0f) * Time.deltaTime);
        }

        if (Input.GetKey("1"))
        {
            transform.Rotate(new Vector3(0f, 0f, 40f) * Time.deltaTime);
        }

        if (Input.GetKey("2"))
        {
            transform.Rotate(new Vector3(0f, 0f, 80f) * Time.deltaTime);
        }

        if (Input.GetKey("3"))
        {
            transform.Rotate(new Vector3(0f, 0f, 110f) * Time.deltaTime);
        }

        if (Input.GetKey("4"))
        {
            transform.Rotate(new Vector3(0f, 0f, 140f) * Time.deltaTime);
        }

        if (Input.GetKey("5"))
        {
            transform.Rotate(new Vector3(0f, 0f, 180f) * Time.deltaTime);
        }


        if (Input.GetKey("6"))
        {
            transform.Rotate(new Vector3(0f, 0f, 250f) * Time.deltaTime);
        }
    }
}
