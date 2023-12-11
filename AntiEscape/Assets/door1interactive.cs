using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Yarn.Unity;

public class door1interactive : MonoBehaviour
{

    
[SerializeField] private string conversationStartNode;
    private DialogueRunner dialogueRunner;
        private bool interactable = true;
         

        public TextMeshProUGUI consoleOutputText;
    // Start is called before the first frame update
    float actions;
    private InMemoryVariableStorage variableStorage;
    void Start()
    {
        variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
         dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        
    }

    // Update is called once per frame
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
           // trying(); 
           
      }
        Debug.Log("First Click");
    }



private void StartConversation() {
    
     
        dialogueRunner.StartDialogue(conversationStartNode);
    }
}


    







