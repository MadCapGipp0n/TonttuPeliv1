using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letkautuskoodi : MonoBehaviour
{
    // Aseta Unity Editorissa ‰‰nitiedostot.
    public AudioClip[] audioClips;
    

    void Start()
    {
        // Aloita toiminto 30-60 sekunnin v‰lein vasta 30 sekunnin kuluttua pelin k‰ynnistytty‰.
        Invoke("StartAudioRepeating", 30f);
    }

    void StartAudioRepeating()
    {
        // K‰ynnist‰ toiminto 30-60 sekunnin v‰lein.
        InvokeRepeating("PlayRandomAudio", 0f, Random.Range(20f, 35f));
    }

    void PlayRandomAudio()
    {
        if (!AudioTriggeri.isSpeaking)
        {
            AudioTriggeri.isSpeaking = true;
            // Valitse satunnainen ‰‰nitiedosto.
            int randomIndex = Random.Range(0, audioClips.Length);
            AudioClip randomClip = audioClips[randomIndex];

            // Soita ‰‰nitiedosto.
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = randomClip;
            audioSource.Play();

            // Lis‰‰ halutut toiminnot, jos tarpeen.
            // Esimerkiksi voit tulostaa konsoliin viestin:
            Debug.Log("Playing random audio!");
            Invoke("Reset", audioSource.clip.length);

            // Tai voit suorittaa muita toimintoja pelilogiikkaasi liittyen.
        }

    }
    void Reset()
    {
        AudioTriggeri.isSpeaking = false;
    }
}

