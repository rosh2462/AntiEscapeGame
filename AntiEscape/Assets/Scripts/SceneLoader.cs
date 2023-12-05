using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Update()
    {
        // Check for mouse click or touch input
        if (Input.GetMouseButtonDown(0))
        {
            // Raycast to check if the click hits the collider of the child trigger
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the clicked object is the child trigger
                if (hit.collider.CompareTag("Selectable"))
                {
                    // Load the next scene
                    LoadNextScene();
                }
            }
        }
    }

    void LoadNextScene()
    {
        // You can replace "NextSceneName" with the name of your next scene
        SceneManager.LoadScene("Scene2");
    }
}
