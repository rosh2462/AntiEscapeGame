using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class trap1AnimalInteractive : MonoBehaviour
{

[SerializeField] private string conversationStartNode;
    private DialogueRunner dialogueRunner;
    private bool interactable = true;
    private AudioSource audioSource;
    public AudioClip clickSound;


    // Start is called before the first frame update
    void Start()
    {
         dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
          audioSource = GetComponent<AudioSource>();
          if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
         audioSource.clip = clickSound;
         
    }
public void OnMouseDown() {
        if (interactable && !dialogueRunner.IsDialogueRunning) {
            StartConversation();
            Debug.Log("Trap Set");
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
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
