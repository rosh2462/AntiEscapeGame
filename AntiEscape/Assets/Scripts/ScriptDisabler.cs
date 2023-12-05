using UnityEngine;
using Yarn.Unity;
using System.Collections;
using System.Collections.Generic;
public class ScriptDisabler : MonoBehaviour
{
    [SerializeField] DialogueRunner runner;

    void Awake()
    {
        runner.AddCommandHandler<string>("DisableScript", DisableScript);
        runner.AddCommandHandler<string>("EnableScript", EnableScript);
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
}
