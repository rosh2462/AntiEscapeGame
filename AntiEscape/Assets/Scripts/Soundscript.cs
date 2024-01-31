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


            case "mood30":
                soundManager.Play("mood30");
                break;
                case "mood40":
                soundManager.Play("mood40");
                break;

            case "mood20":
                soundManager.Play("mood20");
                break;

                case "mood10":
                soundManager.Play("mood10");
                break;
                
            // case "glass_shatter":
            //     soundManager.Play("glass_shatter");
            //     break;
            // case "stumble":
            //     soundManager.Play("stumble");
            //     break;
            // case "scroll":
            //     soundManager.Play("scroll");
            //     break;
            //     case "monster40":
            //     soundManager.Play("monster40");
            //     break;
            //     case "mood40":
            //     soundManager.Play("mood40");
            //     break;
            //     case "monster30":
            //     soundManager.Play("monster30");
            //     break;
            //     case "mood30":
            //     soundManager.Play("mood30");
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