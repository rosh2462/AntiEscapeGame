using System.Collections;
using UnityEngine;
using Yarn.Unity;

//using UnityEngine.Rendering.Universal;
public class setIntensity : MonoBehaviour
{
    // Reference to the YarnSpinner DialogueRunner
    public Yarn.Unity.DialogueRunner dialogueRunner;

    // GameObject to be enabled/disabled
   
   // public UnityEngine.Rendering.Universal.Light2D mylight;

public  GameObject GL;

    private void Start()
    {
        // Ensure the dialogueRunner is assigned
        if (dialogueRunner == null)
        {
            Debug.LogError("DialogueRunner not assigned in YarnCommandExample script!");
        }
        // Subscribe to the Yarn command event
        dialogueRunner.AddCommandHandler("setLightIntensity", SetLightIntensity);
         dialogueRunner.AddCommandHandler("activateLightIntensity", ActivateSetLightIntensity);
       

    }

    // Yarn command to enable the target game object



     void SetLightIntensity()
    {

        
        //GL.GetComponent<UnityEngine.Rendering.Universal.Light2D>().Intensity = 0.0;
        GL.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 0;
        GL.GetComponent<SpriteMask>().enabled = false;
        
        
    }

    void ActivateSetLightIntensity()
{
    GL.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 1;
        GL.GetComponent<SpriteMask>().enabled = true;
}


}

