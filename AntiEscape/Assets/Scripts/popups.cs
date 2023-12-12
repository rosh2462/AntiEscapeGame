using UnityEngine;
using Yarn.Unity;
using System.Collections;
using System.Collections.Generic;

public class popups : MonoBehaviour
{
    public SpriteRenderer spriteRendererMAT;
    public Sprite emotionmathilda_death;

    [YarnCommand("popupsprite")]
    public void Setpop(string expression)
    {

        switch (expression)
        {

            case "mt_death":
                spriteRendererMAT.sprite = emotionmathilda_death;
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
