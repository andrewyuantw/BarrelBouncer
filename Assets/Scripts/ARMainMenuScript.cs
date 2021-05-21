using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARMainMenuScript : MonoBehaviour
{
    public GameObject instructionPanel;
    public delegate void ARstartGame();
    public static event ARstartGame onStartGame;
    


    // Start is called before the first frame update
    void Start()
    {
        
        instructionPanel.SetActive(false);

    }
    


    public void gameScene()
    {
        SceneManager.LoadScene(sceneName: "ARScene");
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
