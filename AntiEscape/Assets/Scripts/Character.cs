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
    public SpriteRenderer spriteRenderer7;
    public SpriteRenderer spriteRenderer8;
    public SpriteRenderer spriteRenderer9;
    public SpriteRenderer spriteRenderer10;
    public SpriteRenderer spriteRenderer11;
    public SpriteRenderer spriteRenderer12;
    public SpriteRenderer spriteRenderer13; 
    public SpriteRenderer spriteRenderer14;
    public SpriteRenderer spriteRenderer15;
    public SpriteRenderer spriteRenderer16; 
    public SpriteRenderer spriteRenderer17;
    public SpriteRenderer spriteRenderer18;
    public SpriteRenderer spriteRenderer19; 
    public SpriteRenderer spriteRenderer20;
    public SpriteRenderer spriteRenderer21;
    public SpriteRenderer spriteRenderer22;
    public SpriteRenderer spriteRenderer23;
    public SpriteRenderer spriteRenderer24;
    public SpriteRenderer spriteRenderer25;
    public SpriteRenderer spriteRenderer26;
    public SpriteRenderer spriteRenderer27;
    public SpriteRenderer spriteRenderer28;

    public Sprite emotionnanditha_idle;
    public Sprite emotionhugh_idle;
    public Sprite emotionmathilda_idle;
    public Sprite emotionmarzanna_idle;
    public Sprite emotionashok_idle;

    public Sprite emotionmathilda_happy;
    public Sprite emotionnanditha_happy;
    public Sprite emotionmarzanna_happy;
    public Sprite emotionashok_happy;
    public Sprite emotionhugh_happy;

    public Sprite emotionashok_annoyed;
    public Sprite emotionhugh_annoyed;
    public Sprite emotionnanditha_annoyed;
    public Sprite emotionmathilda_annoyed;
    public Sprite emotionmarzanna_annoyed;

    public Sprite emotionhugh_afraid;
    public Sprite emotionnanditha_afraid;
    public Sprite emotionmathilda_afraid;
    public Sprite emotionmarzanna_afraid;
    public Sprite emotionashok_afraid;

    public Sprite emotionmarzanna_sad;
    public Sprite emotionnanditha_sad;
    public Sprite emotionhugh_sad;
    public Sprite emotionashok_sad;
    public Sprite emotionmathilda_sad;

    public Sprite emotionmarzanna_embarassed;
    public Sprite emotionashok_embarassed;

    public Sprite emotionhugh_angry;

    public Sprite emotionmathilda_scream;

    void Start() {
        DisableAllSprites();
    }
    
    [YarnCommand("emotionsprite")]
    public void SetSprites(string expression)
    {
        // Disable all sprite renderers
        DisableAllSprites();
        
        // Set the new sprite
        switch (expression)
        {
            case "n_idle":
                spriteRenderer.sprite = emotionnanditha_idle;
                spriteRenderer.enabled = true;
                break;
            case "h_idle":
                spriteRenderer1.sprite = emotionhugh_idle;
                spriteRenderer1.enabled = true;
                break;
            case "mt_idle":
                spriteRenderer2.sprite = emotionmathilda_idle;
                spriteRenderer2.enabled = true;
                break;
            case "mz_idle":
                spriteRenderer3.sprite = emotionmarzanna_idle;
                spriteRenderer3.enabled = true;
                break;
            case "a_idle":
                spriteRenderer4.sprite = emotionashok_idle;
                spriteRenderer4.enabled = true;
                break;
            case "mt_happy":
                spriteRenderer5.sprite = emotionmathilda_happy;
                spriteRenderer5.enabled = true;
                break;
            case "n_happy":
                spriteRenderer6.sprite = emotionnanditha_happy;
                spriteRenderer6.enabled = true;
                break;
            case "a_annoyed":
                spriteRenderer7.sprite = emotionashok_annoyed;
                spriteRenderer7.enabled = true;
                break;
            case "h_afraid":
                spriteRenderer8.sprite = emotionhugh_afraid;
                spriteRenderer8.enabled = true;
                break;
            case "mt_afraid":
                spriteRenderer9.sprite = emotionmathilda_afraid;
                spriteRenderer9.enabled = true;
                break;
            case "n_afraid":
                spriteRenderer10.sprite = emotionnanditha_afraid;
                spriteRenderer10.enabled = true;
                break;
            case "a_afraid":
                spriteRenderer11.sprite = emotionashok_afraid;
                spriteRenderer11.enabled = true;
                break;
            case "mz_afraid":
                spriteRenderer12.sprite = emotionmarzanna_afraid;
                spriteRenderer12.enabled = true;
                break;
            case "mz_happy":
                spriteRenderer13.sprite = emotionmarzanna_happy;
                spriteRenderer13.enabled = true;
                break;
            case "a_happy":
                spriteRenderer14.sprite = emotionashok_happy;
                spriteRenderer14.enabled = true;
                break;
            case "h_happy":
                spriteRenderer15.sprite = emotionhugh_happy;
                spriteRenderer15.enabled = true;
                break;
            case "h_annoyed":
                spriteRenderer16.sprite = emotionhugh_annoyed;
                spriteRenderer16.enabled = true;
                break;
            case "n_annoyed":
                spriteRenderer17.sprite = emotionnanditha_annoyed;
                spriteRenderer17.enabled = true;
                break;
            case "mt_annoyed":
                spriteRenderer18.sprite = emotionmathilda_annoyed;
                spriteRenderer18.enabled = true;
                break;
            case "mz_sad":
                spriteRenderer19.sprite = emotionmarzanna_sad;
                spriteRenderer19.enabled = true;
                break;
            case "n_sad":
                spriteRenderer20.sprite = emotionnanditha_sad;
                spriteRenderer20.enabled = true;
                break;
            case "h_sad":
                spriteRenderer21.sprite = emotionhugh_sad;
                spriteRenderer21.enabled = true;
                break;


            case "mt_sad":
                spriteRenderer22.sprite = emotionmathilda_sad;
                spriteRenderer22.enabled = true;
                break;
            case "mz_annoyed":
                spriteRenderer23.sprite = emotionmarzanna_annoyed;
                spriteRenderer23.enabled = true;
                break;
            case "a_sad":
                spriteRenderer24.sprite = emotionashok_sad;
                spriteRenderer24.enabled = true;
                break;
            case "mt_scream":
                spriteRenderer25.sprite = emotionmathilda_scream;
                spriteRenderer25.enabled = true;
                break;
            case "h_angry":
                spriteRenderer26.sprite = emotionhugh_angry;
                spriteRenderer26.enabled = true;
                break;
            case "mz_embarassed":
                spriteRenderer27.sprite = emotionmarzanna_embarassed;
                spriteRenderer27.enabled = true;
                break;
            case "a_embarassed":
                spriteRenderer28.sprite = emotionashok_embarassed;
                spriteRenderer28.enabled = true;
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
        spriteRenderer7.enabled = false;
        spriteRenderer8.enabled = false;
        spriteRenderer9.enabled = false;
        spriteRenderer10.enabled = false;
        spriteRenderer11.enabled = false;
        spriteRenderer12.enabled = false;
        spriteRenderer13.enabled = false;
        spriteRenderer14.enabled = false;
        spriteRenderer15.enabled = false;
        spriteRenderer16.enabled = false;
        spriteRenderer17.enabled = false;
        spriteRenderer18.enabled = false;
        spriteRenderer19.enabled = false;
        spriteRenderer20.enabled = false;
        spriteRenderer21.enabled = false;
        spriteRenderer22.enabled = false;
        spriteRenderer23.enabled = false;
        spriteRenderer24.enabled = false;
        spriteRenderer25.enabled = false;
        spriteRenderer26.enabled = false;
        spriteRenderer27.enabled = false;
        spriteRenderer28.enabled = false;
    }
    
    [YarnCommand("destroyemotion")]
    public void DisableSprite(string expression)
    {
        switch (expression)
        {
            case "n_idle":               
                this.spriteRenderer.enabled = false;
                break;
            case "h_idle":              
                this.spriteRenderer1.enabled = false;
                break;
            case "mt_idle":              
                this.spriteRenderer2.enabled = false;
                break;
            case "mz_idle":            
                this.spriteRenderer3.enabled = false;
                break;
            case "a_idle":           
                this.spriteRenderer4.enabled = false;
                break;
            case "mt_happy":            
                this.spriteRenderer5.enabled = false;
                break;
            case "n_happy":             
                this.spriteRenderer6.enabled = false;
                break;
            case "a_annoyed":             
                this.spriteRenderer7.enabled = false;
                break;
            case "h_afraid":             
                this.spriteRenderer8.enabled = false;
                break;
            case "mt_afraid":              
                this.spriteRenderer9.enabled = false;
                break;
            case "n_afraid":             
                this.spriteRenderer10.enabled = false;
                break;
            case "a_afraid":            
                this.spriteRenderer11.enabled = false;
                break;
            case "mz_afraid":              
                this.spriteRenderer12.enabled = false;
                break;
            case "mz_happy":               
                this.spriteRenderer13.enabled = false;
                break;
            case "a_happy":          
                this.spriteRenderer14.enabled = false;
                break;
            case "h_happy":             
                this.spriteRenderer15.enabled = false;
                break;
            case "h_annoyed":               
                this.spriteRenderer16.enabled = false;
                break;
            case "n_annoyed":             
                this.spriteRenderer17.enabled = false;
                break;
            case "mt_annoyed":           
                this.spriteRenderer18.enabled = false;
                break;
            case "mz_sad":          
                this.spriteRenderer19.enabled = false;
                break;
            case "n_sad":          
                this.spriteRenderer20.enabled = false;
                break;
            case "h_sad":           
                this.spriteRenderer21.enabled = false;
                break;
            case "mt_sad":     
                this.spriteRenderer22.enabled = false;
                break;
            case "mz_annoyed":            
                this.spriteRenderer23.enabled = false;
                break;
            case "a_sad":             
                this.spriteRenderer24.enabled = false;
                break;
            case "mt_scream":              
                this.spriteRenderer25.enabled = false;
                break;
            case "h_angry":                
                this.spriteRenderer26.enabled = false;
                break;
            case "mz_embarassed":            
                this.spriteRenderer27.enabled = false;
                break;
            case "a_embarassed":              
                this.spriteRenderer28.enabled = false;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }

    [YarnCommand("activateemotion")]
    public void EnableSprite(string expression)
    {
       switch (expression)
        {
            case "n_idle":               
                this.spriteRenderer.enabled = true;
                break;
            case "h_idle":              
                this.spriteRenderer1.enabled = true;
                break;
            case "mt_idle":              
                this.spriteRenderer2.enabled = true;
                break;
            case "mz_idle":            
                this.spriteRenderer3.enabled = true;
                break;
            case "a_idle":           
                this.spriteRenderer4.enabled = true;
                break;
            case "mt_happy":            
                this.spriteRenderer5.enabled = true;
                break;
            case "n_happy":             
                this.spriteRenderer6.enabled = true;
                break;
            case "a_annoyed":             
                this.spriteRenderer7.enabled = true;
                break;
            case "h_afraid":             
                this.spriteRenderer8.enabled = true;
                break;
            case "mt_afraid":              
                this.spriteRenderer9.enabled = true;
                break;
            case "n_afraid":             
                this.spriteRenderer10.enabled = true;
                break;
            case "a_afraid":            
                this.spriteRenderer11.enabled = true;
                break;
            case "mz_afraid":              
                this.spriteRenderer12.enabled = true;
                break;
            case "mz_happy":               
                this.spriteRenderer13.enabled = true;
                break;
            case "a_happy":          
                this.spriteRenderer14.enabled = true;
                break;
            case "h_happy":             
                this.spriteRenderer15.enabled = true;
                break;
            case "h_annoyed":               
                this.spriteRenderer16.enabled = true;
                break;
            case "n_annoyed":             
                this.spriteRenderer17.enabled = true;
                break;
            case "mt_annoyed":           
                this.spriteRenderer18.enabled = true;
                break;
            case "mz_sad":          
                this.spriteRenderer19.enabled = true;
                break;
            case "n_sad":          
                this.spriteRenderer20.enabled = true;
                break;
            case "h_sad":           
                this.spriteRenderer21.enabled = true;
                break;
            case "mt_sad":     
                this.spriteRenderer22.enabled = true;
                break;
            case "mz_annoyed":            
                this.spriteRenderer23.enabled = true;
                break;
            case "a_sad":             
                this.spriteRenderer24.enabled = true;
                break;
            case "mt_scream":              
                this.spriteRenderer25.enabled = true;
                break;
            case "h_angry":                
                this.spriteRenderer26.enabled = true;
                break;
            case "mz_embarassed":            
                this.spriteRenderer27.enabled = true;
                break;
            case "a_embarassed":              
                this.spriteRenderer28.enabled = true;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }
}