using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSound : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
         
        audioSource = GetComponent<AudioSource>();

        // Play the audio clip
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
    }
}
