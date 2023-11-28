using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor: MonoBehaviour
{
    public Animation hingehere;
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
        hingehere.Play ();
        }
    }
}
