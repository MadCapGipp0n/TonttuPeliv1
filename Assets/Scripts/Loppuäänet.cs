using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loppuäänet : MonoBehaviour
{
    public AudioClip biisi;
    public AudioClip loppusanat;
    private AudioSource sound;
    bool isSpeaking = false;



    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        sound.clip = loppusanat;
        sound.Play();
    }
    private void puhe()
    {
        sound.clip = loppusanat;
        sound.Play();
    }
    private void musa()
    {
        sound.clip = biisi;
        sound.Play();
    }
}
