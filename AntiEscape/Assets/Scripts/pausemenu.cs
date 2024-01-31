using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool ispaused;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){

            if(ispaused){
                Resume();
            }
            else
            {
                PauseGame();
            }

        }
    }

    public void PauseGame(){
 pauseMenu.SetActive(true);
 Time.timeScale=0f;
 ispaused=true;
    }

    public void Resume(){

pauseMenu.SetActive(false);
 Time.timeScale=1f;
  ispaused=false;
    }


public void Newgame(){

    Time.timeScale=1f;
    SceneManager.LoadScene("Scene_2");


}

public void QuitGame(){

    Application.Quit();


}

public void MainMenu(){

    SceneManager.LoadScene("MainMenu");
}
}
