using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class MainMenuScript : MonoBehaviour
{
    
    
    public GameObject instructionPanel;
    public delegate void startGame();
    public static event startGame onStartGame;


    // Start is called before the first frame update
    void Start()
    {
        
        instructionPanel.SetActive(false);
        
    }

    
    public void gameScene()
    {
        SceneManager.LoadScene(sceneName: "DemoScene");
        onStartGame();
    }

    

    public void exitGame()
    {
        Application.Quit();
    }
    
    void Update()
    {
        
    }
}
