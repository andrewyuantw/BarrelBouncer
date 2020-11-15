using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class regularScreenScript : MonoBehaviour
{
    private const string V = "Score: ";
    public GameObject scoreKeeper;
    public PlayerController player;
    
    void Start()
    {
        
    }

    void Update()
    {
        TMP_Text currscore = scoreKeeper.GetComponent<TextMeshProUGUI>();
        currscore.text = V + player.score;
    }
}
