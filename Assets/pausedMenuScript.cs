using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pausedMenuScript : MonoBehaviour
{
    public Button menuButton;
    public Button restartButton;
    public GameObject player;
    
    
    
    void Start()
    {
        Button menubtn = menuButton.GetComponent<Button>();
        Button restartbtn = restartButton.GetComponent<Button>();
        menubtn.onClick.AddListener(goToMenu);
        restartbtn.onClick.AddListener(restart);
    }

    
    void Update()
    {
        
    }
    void goToMenu()
    {

        SceneManager.LoadScene(sceneName: "MainMenu");
        
    }
    void restart()
    {
        SceneManager.LoadScene(sceneName: "DemoScene");
        player.GetComponent<PlayerController>().enabled = true;
        Time.timeScale = 1.0f;
    }
}
