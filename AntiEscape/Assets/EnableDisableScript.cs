using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableScript : MonoBehaviour
{
     public GameObject targetObject;

    // Enable the GameObject
    public void EnableObject()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(true);
        }
    }

    // Disable the GameObject
    public void DisableObject()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(false);
        }
    }
}
