using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesScripts : MonoBehaviour
{
    
    void Start()
    {
        PlayerController.onDie += loseLife;
    }

    
    void Update()
    {
        
    }

    public void loseLife()
    {
        GameObject heart = this.gameObject.transform.GetChild(0).gameObject;
        Destroy(heart);
    }
    private void OnDestroy()
    {
        PlayerController.onDie -= loseLife;
    }
}