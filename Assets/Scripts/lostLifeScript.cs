using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lostLifeScript : MonoBehaviour
{
    public float timeRemaining = 1;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == true)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                gameObject.SetActive(false);
                timeRemaining = 1;
            }
        }

    }
}
