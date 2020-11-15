using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class MainMenuScript : MonoBehaviour
{
    public Button instrButton;
    public Button xButton;
    public Button exitButton;
    public Button startButton;
    public GameObject instructionPanel;
    public delegate void startGame();
    public static event startGame onStartGame;


    // Start is called before the first frame update
    void Start()
    {
        Button instructionsbtn = instrButton.GetComponent<Button>();
        Button xbtn = xButton.GetComponent<Button>();
        Button exitbtn = exitButton.GetComponent<Button>();
        Button startbtn = startButton.GetComponent<Button>();
        instructionPanel.SetActive(false);
        instructionsbtn.onClick.AddListener(showInstructions);
        xbtn.onClick.AddListener(hideInstructions);
        exitbtn.onClick.AddListener(exitGame);
        startbtn.onClick.AddListener(gameScene);
    }

    void showInstructions()
    {
        instructionPanel.SetActive(true);
    }
    public void gameScene()
    {
        SceneManager.LoadScene(sceneName: "DemoScene");
        onStartGame();
    }

    void hideInstructions()
    {
        instructionPanel.SetActive(false);
    }

    void exitGame()
    {
        Application.Quit();
    }
    
    void Update()
    {
        
    }
}
