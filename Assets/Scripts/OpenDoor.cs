using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor: MonoBehaviour
{
    public Animation hingehere;
    public PlayerMovementV1 keys;
    
    void Start()
    {
        keys = FindObjectOfType<PlayerMovementV1>();
    }

    // && FindObjectOfType<Player>.KeyAmount >= 1) tarkistaa avaimet 
   
    
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E)&& keys.KeyAmount >= 1)
        {
            PlayerMovementV1 playerMovement = other.GetComponent<PlayerMovementV1>();
            keys.KeyAmount -= 1;
            hingehere.Play ();
        }
    }

}
