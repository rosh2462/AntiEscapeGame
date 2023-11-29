using UnityEngine;
using Yarn.Unity;

public class Character : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRenderer1;
    public SpriteRenderer spriteRenderer2;
    public SpriteRenderer spriteRenderer3;
    public SpriteRenderer spriteRenderer4;
    public SpriteRenderer spriteRenderer5;
    public SpriteRenderer spriteRenderer6;

    public Sprite emotionnanditha_idle;
    public Sprite emotionhugh_idle;
    public Sprite emotionmathilda_idle;
    public Sprite emotionmarzanna_idle;
    public Sprite emotionashok_idle;
    public Sprite emotionmathilda_happy;
    public Sprite emotionnanditha_happy;

  
    [YarnCommand("setsprites")]
    public void SetSprites(string expression)
    {
        
        // Disable all sprite renderers
        DisableAllSprites();
        
        // Set the new sprite
        switch (expression)
        {
            case "emotionnanditha_idle":
                spriteRenderer.sprite = emotionnanditha_idle;
                spriteRenderer.enabled = true;
                break;
            case "emotionhugh_idle":
                spriteRenderer1.sprite = emotionhugh_idle;
                spriteRenderer1.enabled = true;
                break;
            case "emotionmathilda_idle":
                spriteRenderer2.sprite = emotionmathilda_idle;
                spriteRenderer2.enabled = true;
                break;
            case "emotionmarzanna_idle":
                spriteRenderer3.sprite = emotionmarzanna_idle;
                spriteRenderer3.enabled = true;
                break;
            case "emotionashok_idle":
                spriteRenderer4.sprite = emotionashok_idle;
                spriteRenderer4.enabled = true;
                break;
            case "emotionmathilda_happy":
                spriteRenderer5.sprite = emotionmathilda_happy;
                spriteRenderer5.enabled = true;
                break;
            case "emotionnanditha_happy":
                spriteRenderer6.sprite = emotionnanditha_happy;
                spriteRenderer6.enabled = true;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }

    // Method to disable all sprite renderers
    private void DisableAllSprites()
    {
        spriteRenderer.enabled = false;
        spriteRenderer1.enabled = false;
        spriteRenderer2.enabled = false;
        spriteRenderer3.enabled = false;
        spriteRenderer4.enabled = false;
        spriteRenderer5.enabled = false;
        spriteRenderer6.enabled = false;
       
    }

    [YarnCommand("destroysprite")]
    public void DestroySprite(string tagToFind)
    {
        GameObject myObject = GameObject.FindGameObjectWithTag(tagToFind);
        Debug.Log("Tag found");
        myObject.SetActive(false);
    }

}