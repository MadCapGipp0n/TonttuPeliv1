using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTriggeri : MonoBehaviour
{
    public AudioClip speechClip; // Äänitiedosto, joka sisältää puheen.
    private AudioSource audioSource;
    private bool canSpeak = true;
    public static bool isSpeaking = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Tarkista, onko pelaaja törmännyt tiettyyn esineeseen ja voiko hahmo puhua.
        if (canSpeak && other.CompareTag("Player") && !isSpeaking)
        {
            isSpeaking = true;
            // Kutsu metodia, joka saa hahmon puhumaan ja aseta viive.
            Invoke("Speak", 1f);

            // Estä hahmoa puhumasta välittömästi uudelleen.
            canSpeak = false;
        }
    }

    void Speak()
    {
        // Tässä asetetaan äänitiedosto AudioSourceen ja aloitetaan toisto.
        audioSource.clip = speechClip;
        audioSource.Play();

        // Aseta viive hahmon seuraavaa puhetta varten.
        Invoke("ResetSpeechPermission", audioSource.clip.length);
    }

    void ResetSpeechPermission()
    {
        // Anna lupa hahmolle puhua uudelleen vastaavasti äänitiedoston pituuden jälkeen.
        canSpeak = true;
        isSpeaking = false;
    }
}
