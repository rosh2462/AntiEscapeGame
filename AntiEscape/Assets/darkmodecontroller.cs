using System.Collections;
using UnityEngine;
using Yarn.Unity;


public class darkmodecontroller : MonoBehaviour
{
     public Yarn.Unity.DialogueRunner dialogueRunner;
      public GameObject darkmodegameobj;





private void Start()
    {
        // Ensure the dialogueRunner is assigned
        if (dialogueRunner == null)
        {
            Debug.LogError("DialogueRunner not assigned in YarnCommandExample script!");
        }

        // Subscribe to the Yarn command event
        dialogueRunner.AddCommandHandler("darkmodeon", DarkModeOn);
        dialogueRunner.AddCommandHandler("darkmodeoff", DarkModeOff);
        

         //dialogueRunner.AddCommandHandler("darkmodeoff", DarkModeOff);


    }

       private void DarkModeOn()
    {
        if (darkmodegameobj != null)
        {
            darkmodegameobj.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    private void DarkModeOff()
    {
        if (darkmodegameobj != null)
        {
             darkmodegameobj.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    














}
