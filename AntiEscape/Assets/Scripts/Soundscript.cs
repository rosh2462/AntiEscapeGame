using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Soundscript : MonoBehaviour
{
 public SoundManager soundManager;

  
    private void Awake()
    {
         
        soundManager = FindObjectOfType<SoundManager>();
    }

    [YarnCommand("playsound")]
    public void PlaySound(string soundName)
    {
         
        switch (soundName)
        {
            case "glass_shatter":
                soundManager.Play("glass_shatter");
                break;
            // case "sound2":
            //     soundManager.Play("sound2");
            //     break;
            // Add more cases as needed
            default:
                Debug.LogWarning("Sound " + soundName + " not found!");
                break;
        }
    }
 }
















//       private AudioSource audioSource;
//      public AudioClip clickSound;

// public Yarn.Unity.DialogueRunner runner;
//       void Start()
//     {
         
//   runner.AddCommandHandler("playSound", PlaySound);
         
//          audioSource = GetComponent<AudioSource>();
//           if (audioSource == null)
//         {
//             audioSource = gameObject.AddComponent<AudioSource>();
//         }
         
         
          
//     }

 

//        void PlaySound()
//     {

//         if (audioSource != null && clickSound != null)
//         {
//             audioSource.PlayOneShot(clickSound);
//             Debug.Log("Sound Plays");
//         }
//     }