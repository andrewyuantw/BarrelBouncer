using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARScreenswitcher : MonoBehaviour
{
    public GameObject setupScreen;
    public GameObject regularScreen;
    public GameObject gameOverScreen;
    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        setupScreen.SetActive(true);
        regularScreen.SetActive(false);
        timer.onEndGame += gameOver;
    }
    private void OnDestroy()
    {
        timer.onEndGame -= gameOver;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        Debug.Log("here");
        gameOverScreen.SetActive(true);
        regularScreen.SetActive(false);
        gameManager.GetComponent<ARGameManager>().enabled = false;
        
    }
}
