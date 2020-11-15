using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gameoverscript : MonoBehaviour
{

    
    void Start()
    {
        ScreenSwitcher.onGameOver2 += gameOver;
        
    }

    void Update()
    {
        
    }

    void gameOver(int score)
    {
        Debug.Log("Hello");
        TMP_Text currscore = GameObject.Find("ScoreFinal").GetComponent<TextMeshProUGUI>();
        currscore.text = "Your final score is " + score;
    }
    private void OnDestroy()
    {
        ScreenSwitcher.onGameOver2 -= gameOver;
    }
}
