using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scenemanage : MonoBehaviour
{
     void Update()
    {
        // Check if the Q key is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Load the next scene
            LoadNextScene();
          //  Debug.Log("Load next scene");
        }
    }

    // Function to load the next scene
    void LoadNextScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene by incrementing the scene index
        SceneManager.LoadScene(currentSceneIndex + 1);

        // If you want to loop back to the first scene when reaching the end, you can use the following:
        // SceneManager.LoadScene((currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings);
    }
}
