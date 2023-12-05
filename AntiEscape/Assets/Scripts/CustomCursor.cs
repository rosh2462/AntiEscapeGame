using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class CustomCursor : MonoBehaviour
{
   public Texture2D defaultCursorTexture;
    public Texture2D hoverCursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

 private void Start()
 {
    OnMouseExit();
 }
    private void OnMouseOver()
    {
        Cursor.SetCursor(hoverCursorTexture, hotSpot, cursorMode);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(defaultCursorTexture, Vector2.zero, CursorMode.Auto);
    }

 
    // private void Update()
    // {
        
    //     RaycastHit hit;
    //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //     if (Physics.Raycast(ray, out hit))
    //     {
           
           
    //         if (hit.collider.CompareTag("Test1"))
    //         {
    //             Cursor.SetCursor(hoverCursorTexture, hotSpot, cursorMode);
    //              Debug.Log("hover texture");
    //         }
    //         else
    //         {
    //             Cursor.SetCursor(defaultCursorTexture, Vector2.zero, CursorMode.Auto);
    //                  Debug.Log("not hover texture");
    //         }
        
    }

