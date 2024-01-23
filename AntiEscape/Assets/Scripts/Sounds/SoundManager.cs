using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
  public AudioClip glass_shatter;
     
    // Add more AudioClip fields as needed
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Play(string soundName)
    {
        switch (soundName)
        {
            case "glass_shatter":
                audioSource.clip = glass_shatter;
                break;
             
            // Add more cases as needed
            default:
                Debug.LogWarning("Sound " + soundName + " not found!");
                return;
        }
        audioSource.Play();
    }
}