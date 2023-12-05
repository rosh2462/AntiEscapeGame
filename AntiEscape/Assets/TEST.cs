using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;
using UnityEditor;
using Yarn;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using System.IO;

public class TEST : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    public GameObject CharacterChoice;
    public GameObject Game;
    public GameObject screenTemplate;
    public GameObject characterIdle;
    public GameObject characterTitle;
    public GameObject animationTemplate;
    public GameObject enemiesTemplate;

    private InMemoryVariableStorage variableStorage;

    private void Start()
    {
        CharacterChoice.SetActive(true);
        Game.SetActive(false);
        animationTemplate.SetActive(false);
        enemiesTemplate.SetActive(false);

        variableStorage = FindAnyObjectByType<InMemoryVariableStorage>();

        dialogueRunner.AddCommandHandler("gameOver", gameOver);
        dialogueRunner.AddCommandHandler<string>("changeBackground", changeBackground);
        dialogueRunner.AddCommandHandler<int>("changeCharacter", changeCharacter);
        dialogueRunner.AddCommandHandler("battleBackground", changeBackgroundBattle);
        dialogueRunner.AddCommandHandler<string, string, string>("animate", animate);
        dialogueRunner.AddCommandHandler<string>("animateEnemie", animateEnemie);
        dialogueRunner.AddCommandHandler("deactivateEnemie", deactivateEnemie);
    }

    public void gameOver()
    {
        SceneManager.LoadScene(0);
    }

    public void chooseCharacter(int character)
    {
        float temp;
        changeCharacter(character);

        if (!variableStorage.TryGetValue("$maincharacter", out temp))
        {
            temp = 0;
        }

        variableStorage.SetValue("$maincharacter", character);
        CharacterChoice.SetActive(!CharacterChoice.activeSelf);
        Game.SetActive(!Game.activeSelf);
        dialogueRunner.StartDialogue("initialize");
    }

    public void changeImage(GameObject gameObject, string newImagePath, string newAnimatorPath)
    {
        UnityEngine.UI.Image imageComponent = gameObject.GetComponent<UnityEngine.UI.Image>();
        Sprite newSprite = Resources.Load<Sprite>(newImagePath);

        if (newSprite != null)
        {
            imageComponent.sprite = newSprite;
        }
        else
        {
            Debug.LogWarning("new sprite not found : " + newImagePath);
        }


        Animator animator = gameObject.GetComponent<Animator>();
        RuntimeAnimatorController newController = Resources.Load<RuntimeAnimatorController>(newAnimatorPath);

        if (newController != null)
        {
            animator.runtimeAnimatorController = newController;
        }
        else
        {
            Debug.LogWarning("new animator controller not found : " + newAnimatorPath);
        }
    }

    public void deactivateAnimation(GameObject gameObject)
    {

    }

    public void changeBackground(string view)
    {
        string backgroundBasePath = "ART/BACKGROUNDS/";

        GameObject gameObject = screenTemplate;
        string newImagePath = backgroundBasePath + view + "/" + view + " 1";
        string newAnimatorPath = backgroundBasePath + view + "/" + view;

        changeImage(gameObject, newImagePath, newAnimatorPath);
    }

    public void displayCharacter(string character)
    {
        string characterBasePath = "ART/CHARACTERS/";
        string characterTitleBasePath = "ART/UI/CHARACTER TITLES/";

        GameObject gameObjectIdle = characterIdle;
        string newImagePathIdle = characterBasePath + character + "/MENU PORTRAIT/IDLE/Idle 1";
        string newAnimatorPathIdle = characterBasePath + character + "/MENU PORTRAIT/IDLE/" + character + " IDLE";

        changeImage(gameObjectIdle, newImagePathIdle, newAnimatorPathIdle);

        GameObject gameObjectTitle = characterTitle;
        string newImagePathTitle = characterTitleBasePath + character + "/1";
        string newAnimatorPathTitle = characterTitleBasePath + character + "/" + character + " TITLE";

        changeImage(gameObjectTitle, newImagePathTitle, newAnimatorPathTitle);
    }

    public void changeCharacter(int character)
    {
        string newCharacter = "";
        switch (character)
        {
            case 1:
                newCharacter = "EXORCIST";
                break;
            case 2 : 
                newCharacter = "FALCONER";
                break;
            case 3 :
                newCharacter = "MARINE";
                break;
            case 4 :
                newCharacter = "GARDENER";
                break;
            default:
                break;
        }

        displayCharacter(newCharacter);
    }

    public void changeBackgroundBattle()
    {
        string backgroundBasePath = "ART/BACKGROUNDS/";

        string placeName = screenTemplate.GetComponent<Animator>().runtimeAnimatorController.name;
        GameObject gameObject = screenTemplate;
        string newImagePath = backgroundBasePath + placeName + "/BATTLE/" + placeName + " 1 BATTLE";
        string newAnimatorPath = backgroundBasePath + placeName + "/BATTLE/" + placeName + " BATTLE";

        changeImage(gameObject, newImagePath, newAnimatorPath);
    }

    public void animate(string type, string attacking, string animationName)
    {
        string animationBasePath = "ART/ANIMATIONS/";

        GameObject gameObject = animationTemplate;
        string newImagePath = animationBasePath + type + "/" + attacking + "/" + animationName + "/Frame0001";
        string newAnimatorPath = animationBasePath + type + "/" + attacking + "/" + animationName + "/" + animationName;

        changeImage(gameObject, newImagePath, newAnimatorPath);

        animationTemplate.SetActive(true);
    }

    public void animateEnemie(string enemie)
    {
        string enemiesBasePath = "ART/ENEMIES/";

        GameObject gameObject = enemiesTemplate;
        string newImagePath = enemiesBasePath + enemie + "/" + enemie + " 1";
        string newAnimatorPath = enemiesBasePath + enemie + "/" + enemie;

        changeImage(gameObject, newImagePath, newAnimatorPath);

        enemiesTemplate.SetActive(true);
    }
    public void OnAnimationFinished()
    {
        animationTemplate.SetActive(false);
    }

    public void deactivateEnemie()
    {
        enemiesTemplate.SetActive(false);
    }
}
