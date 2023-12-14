using UnityEngine;
using Yarn.Unity;
using System.Collections;
using System.Collections.Generic;

public class popups : MonoBehaviour
{
    public SpriteRenderer spriteRendererPOP;
    public Sprite popup1note;

    [YarnCommand("Enablepopup")]
    public void Setpop(string expression)
    {

        switch (expression)
        {

            case "popup1note":
                spriteRendererPOP.sprite = popup1note;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }

    [YarnCommand("disablePopup")]
    public void DestroySprite(string tagToFind)
    {
        GameObject myObject = GameObject.FindGameObjectWithTag(tagToFind);
        Debug.Log("Tag found");
        myObject.SetActive(false);
    }



}
