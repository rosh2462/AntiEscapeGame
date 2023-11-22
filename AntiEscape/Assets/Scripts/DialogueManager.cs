using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Yarn.Unity;

public class DialogueManager : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRendererAnimal;

    public Sprite door1crate;
    public Sprite emotionnanditha;
    public Sprite emotionhugh;
    public Sprite emotionmathilda;
    public Sprite emotionmarzanna;
    public Sprite trap1animal;

    public Sprite emotionashok;

  //  public Sprite extra1scroll;

    private Sprite[] characters; // Array to hold character sprites
    private int currentIndex; // Index to keep track of the current character sprite
 
    void Start()
    {
        characters = new Sprite[] { emotionnanditha, emotionhugh, emotionmathilda};
        currentIndex = 0; // Start with the first character
    }

    [YarnCommand("setsprite")]
    public void SetSprite(string expression)
    {

        switch (expression)
        {

            case "door1crate_open":
                spriteRenderer.sprite = door1crate;
                break;

            case "animal_activated":
                spriteRendererAnimal.sprite = trap1animal;
                break;

            case "idle":

                spriteRenderer.sprite = characters[currentIndex];
                currentIndex = (currentIndex + 1) % characters.Length;
                break;

            case "scared":
                spriteRenderer.sprite = emotionmarzanna;
                break;

            // case "extra1scroll_idle":
            //     spriteRenderer.sprite = extra1scroll;
            //     break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }

}