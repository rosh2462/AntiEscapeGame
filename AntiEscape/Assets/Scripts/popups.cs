using UnityEngine;
using Yarn.Unity;
using System.Collections;
using System.Collections.Generic;

public class popups : MonoBehaviour
{
    public SpriteRenderer spriteRendererPOP;
     public SpriteRenderer spriteRendererPOPLetter;

    public SpriteRenderer spriteRendererPOPCarrot;

    public SpriteRenderer POP2Key;

    public SpriteRenderer POP2Remote;

    public SpriteRenderer POP3Code;

    public SpriteRenderer POP3key;


    public SpriteRenderer POP3Cage;
    public Sprite popupkey;

    public Sprite popupletter;

    public Sprite popupcarrot;

    public Sprite popup2key;

    public Sprite popup2remote;
     public Sprite popup3code;

     public Sprite popup3cage;

     public Sprite popup3key;
     


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
            case "popup2key":
                POP2Key.sprite = popup2key;
                break;
            case "popup2remote":
                POP2Remote.sprite = popup2remote;
                break;
             case "popup3code":
                POP3Code.sprite = popup3code;
                break;
            case "popup3cagekey":
                POP3Cage.sprite=popup3cage;
                break;
            case "popup3key":
                POP3key.sprite=popup3key;  
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
