using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(100f*Time.deltaTime,0f,0f, Space.Self); 
    }
   public GameObject Hinge;
    

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
         if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            Hinge.GetComponent<BoxCollider>().enabled = true; 
        }
    }
   
}

