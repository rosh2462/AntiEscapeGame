using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;
using TMPro;

public class nandithaDeathInteractive : MonoBehaviour
{
    [SerializeField] private string conversationStartNode;
    private DialogueRunner dialogueRunner;
    private bool interactable = true;
     private AudioSource audioSource;
     public AudioClip clickSound;

     public TextMeshProUGUI consoleOutputText;
      float actions;
    private InMemoryVariableStorage variableStorage;
  
 
    void Start()
    {
         
variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
         dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
         audioSource = GetComponent<AudioSource>();
          if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
      //   audioSource.clip = clickSound;
         
    }



    void Update()
    {
        variableStorage.TryGetValue("$actions", out actions);
        consoleOutputText.text = "" + actions.ToString();
    }


public void OnMouseDown() {
        if (interactable && !dialogueRunner.IsDialogueRunning) {
            StartConversation();
            variableStorage.TryGetValue("$actions", out actions);
variableStorage.SetValue("$actions", actions);
//Debug.Log("Value:"+actions);
consoleOutputText.text = "" + actions.ToString();
           // Debug.Log("Trap Set");
            PlayClickSound();
        }
    }
    
     private void StartConversation() {
        
      //  isCurrentConversation = true;
         
        dialogueRunner.StartDialogue(conversationStartNode);
    }

         void PlayClickSound()
    {
        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
            Debug.Log("Sound Plays");
        }
    }
}



