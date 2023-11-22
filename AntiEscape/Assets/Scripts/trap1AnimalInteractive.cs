using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class trap1AnimalInteractive : MonoBehaviour
{

[SerializeField] private string conversationStartNode;
    private DialogueRunner dialogueRunner;
    private bool interactable = true;


    // Start is called before the first frame update
    void Start()
    {
         dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
         
    }
public void OnMouseDown() {
        if (interactable && !dialogueRunner.IsDialogueRunning) {
            StartConversation();
            Debug.Log("Trap Set");
        }
    }
    
     private void StartConversation() {
        
      //  isCurrentConversation = true;
         
        dialogueRunner.StartDialogue(conversationStartNode);
    }
    
    
    
    
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
