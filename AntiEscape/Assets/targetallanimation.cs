using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class targetallanimation : MonoBehaviour
{
     public Yarn.Unity.DialogueRunner dialogueRunner;

     public GameObject animal;
     public GameObject crate;

     public GameObject tools;

     public GameObject chemicals;
     
     public GameObject corpse;

     private void Start()
    {
        // Ensure the dialogueRunner is assigned
        if (dialogueRunner == null)
        {
            Debug.LogError("DialogueRunner not assigned in YarnCommandExample script!");
        }
        dialogueRunner.AddCommandHandler("disableanimation", DisableAnimation);
    }



     private void DisableAnimation()
    {
         
           animal.GetComponent<animalanimate>().enabled = false;
            crate.GetComponent<crateanimate>().enabled = false;
             tools.GetComponent<toolanimate>().enabled = false;
             chemicals.GetComponent<chemicalanimation>().enabled = false;

            
      
    }
}
