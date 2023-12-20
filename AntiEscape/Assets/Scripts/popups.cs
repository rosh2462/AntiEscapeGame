using UnityEngine;
using Yarn.Unity;
using System.Collections;
using System.Collections.Generic;

public class popups : MonoBehaviour
{
    public SpriteRenderer spriteRendererPOP;
     public SpriteRenderer spriteRendererPOPLetter;

    public SpriteRenderer spriteRendererPOPCarrot;
    public Sprite popupkey;

    public Sprite popupletter;

    public Sprite popupcarrot;

    [YarnCommand("popupsprite")]
    public void Setpop(string expression)
    {

        switch (expression)
        {
            
            case "popup1letter":
                spriteRendererPOPLetter.sprite = popupletter;
                break;
            case "popup1key":
                spriteRendererPOP.sprite = popupkey;
                break;
            case "popup2carrot":
                spriteRendererPOPCarrot.sprite = popupcarrot;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }

    [YarnCommand("destroypopup")]
    public void DestroySprite(string tagToFind)
    {
        GameObject myObject = GameObject.FindGameObjectWithTag(tagToFind);
        Debug.Log("Tag found");
        myObject.SetActive(false);
    }



}
