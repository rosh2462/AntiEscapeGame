using UnityEngine;
using Yarn.Unity;
using System.Collections;
using System.Collections.Generic;

public class popups : MonoBehaviour
{
    public SpriteRenderer spriteRendererPOP;
     public SpriteRenderer spriteRendererPOPLetter;

    public SpriteRenderer spriteRendererPOPCarrot;
    public SpriteRenderer POPgrimoire;
    public SpriteRenderer POPCandle;
    public SpriteRenderer POP2Key;

    public SpriteRenderer POP2Remote;

    public SpriteRenderer POP3Code;

    public SpriteRenderer POP3key;

    public SpriteRenderer POP5Card;

    public SpriteRenderer POP5Key;

public SpriteRenderer POP5Finger;

 public SpriteRenderer POP4key;
    public SpriteRenderer POP3Cage;
    public Sprite popupkey;

    public Sprite popupletter;

    public Sprite popupcarrot;

    public Sprite popupcandle;

    public Sprite popup2key;

    public Sprite popup2remote;
     public Sprite popup3code;

     public Sprite popup3cage;

     public Sprite popup3key;
     
     public Sprite popup4key;

     public Sprite popupgrimoire;

     public Sprite popup5card;

     public Sprite popup5key;
    public Sprite   popup5finger;
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
            case "popup4candle":
                POPCandle.sprite = popupcandle;
                break;
            case "popup4key":
                POP4key.sprite = popup4key;
                break;
            case "popup4grimoire":
                POPgrimoire.sprite = popupgrimoire;
                break;
            case "popup5card":
                POP5Card.sprite = popup5card;
                break;
            case "popup5key":
                POP5Key.sprite = popup5key;
                break;
            case "popup5finger":
                POP5Finger.sprite = popup5finger;
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
