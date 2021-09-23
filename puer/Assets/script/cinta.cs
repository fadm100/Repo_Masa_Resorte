using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cinta : MonoBehaviour
{
    public GameObject banda;
    public Transform ban;
    public float speed;

    void OnTriggerStay(Collider other)
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position, ban.position, speed * Time.deltaTime);
    }
}
