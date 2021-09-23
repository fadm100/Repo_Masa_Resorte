using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuicuit2 : MonoBehaviour
{
    public float velocidad = 3f;
    public float velocidad2 = 7f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("j"))
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("l"))
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("i"))
        {
            transform.position += Vector3.up * velocidad2 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("k"))
        {
            transform.position += Vector3.down * velocidad2 * Time.deltaTime;
        }

    }
}