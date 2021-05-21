using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pausedMenuScript : MonoBehaviour
{
    
    public GameObject player;
    
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void goToMenu()
    {

        SceneManager.LoadScene(sceneName: "MainMenu");
        
    }
    public void restart()
    {
        SceneManager.LoadScene(sceneName: "DemoScene");
        player.GetComponent<PlayerController>().enabled = true;
        Time.timeScale = 1.0f;
    }
}
