using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
   public Texture2D defaultCursorTexture;
    public Texture2D hoverCursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    private void OnMouseEnter()
    {
        Cursor.SetCursor(hoverCursorTexture, hotSpot, cursorMode);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(defaultCursorTexture, Vector2.zero, CursorMode.Auto);
    }

    private void Update()
    {
        // Perform a raycast to check if the cursor is hovering over an object
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            // Check if the object has a specific tag or component to indicate hover
            if (hit.collider.CompareTag("Tools1"))
            {
                Cursor.SetCursor(hoverCursorTexture, hotSpot, cursorMode);
            }
            else
            {
                Cursor.SetCursor(defaultCursorTexture, Vector2.zero, CursorMode.Auto);
            }
        }
        else
        {
            // If not hitting any object, switch back to default cursor
            Cursor.SetCursor(defaultCursorTexture, Vector2.zero, CursorMode.Auto);
        }
    }
}
