using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSwitcher : MonoBehaviour
{
    public GameObject regularScreen;
    public GameObject GameOverScreen;
    public GameObject PauseScreen;
    public GameObject player;
    public int escape = 0;
    private IEnumerator coroutine;
    public delegate void gameOver2(int score);
    public static gameOver2 onGameOver2;
    public int score = 0;

    void Start()
    {
        
        regular();
        player = GameObject.FindGameObjectWithTag("Player");
        MainMenuScript.onStartGame += regular;
        PlayerController.onGameOver += gameOverStart;
        
    }

    void regular()
    {
        //player.GetComponent<PlayerController>().enabled = true;
        Time.timeScale = 1.0f;
        regularScreen.SetActive(true);
        GameOverScreen.SetActive(false);
        PauseScreen.SetActive(false);
    }
    IEnumerator gameOverWait()
    {
        gameOver();
        yield return null;
        onGameOver2(this.score);
        
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(sceneName: "MainMenu");
    }
    void gameOver()
    {
        
        regularScreen.SetActive(false);
        GameOverScreen.SetActive(true);
        PauseScreen.SetActive(false);
        
    }
    public void gameOverStart(int score)
    {
        coroutine = gameOverWait();
        this.score = score;
        StartCoroutine(coroutine);
    }
    void pause()
    {
        regularScreen.SetActive(false);
        GameOverScreen.SetActive(false);
        PauseScreen.SetActive(true);
    }
    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escape ++;
            if (escape % 2 == 1)
            {
                pause();
                Time.timeScale = 0.0f;
                player.GetComponent<PlayerController>().enabled = false;
            }
            else
            {
                regular();
                player.GetComponent<PlayerController>().enabled = true;
                Time.timeScale = 1.0f;
            }
            
        }
    }
    private void OnDestroy()
    {
        MainMenuScript.onStartGame -= regular;
        PlayerController.onGameOver -= gameOverStart;
    }
}
