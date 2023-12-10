using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextscene : MonoBehaviour

{
     public string scenename;
     public PlayerMovementV1 keys;
 
     void OnTriggerEnter(Collider other){
         if(other.CompareTag("Player")&& keys.KeyAmount >=1 && !AudioTriggeri.isSpeaking)
        {
            keys.KeyAmount -=1;
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
     }
 }