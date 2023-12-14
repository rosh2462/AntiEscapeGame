using UnityEngine;
using Yarn.Unity;
using System.Collections;
using System.Collections.Generic;
public class ScriptDisabler : MonoBehaviour
{
    [SerializeField] DialogueRunner runner;

    void Awake()
    {
        runner.AddCommandHandler<string>("DisableCameraScript", DisableScript);
        runner.AddCommandHandler<string>("EnableCameraScript", EnableScript);
        runner.AddCommandHandler<string>("DisableToolInteractive", DisableToolInteractive);
    }

    public void DisableScript(string scriptName)
    {
        // Find the GameObject with the specified script and disable it
    GameObject varGameObject = GameObject.FindWithTag("MainCamera"); 
    varGameObject.GetComponent<camerafollowscript>().enabled = false;
       
    }

    public void EnableScript(string scriptName)
    {
        // Find the GameObject with the specified script and disable it
    GameObject varGameObject = GameObject.FindWithTag("MainCamera"); 
    varGameObject.GetComponent<camerafollowscript>().enabled = true;
       
    }

public void DisableToolInteractive(string scriptName)
    {
        // Find the GameObject with the specified script and disable it
    GameObject varGameObject = GameObject.FindWithTag("Tools_Activated"); 
    varGameObject.GetComponent<toolinteractivee>().enabled = false;
       
    }


}
