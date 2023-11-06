using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Convert mouse position to world space
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; // Set z-coordinate to 0 for 2D games

            // Check if the mouse click hits the GameObject
            Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);
            if (hitCollider != null && hitCollider.gameObject == gameObject)
            {
                // The GameObject is clicked, print a message to the console
                Debug.Log("GameObject Clicked: " + gameObject.name);
            }
        }
    }
}
