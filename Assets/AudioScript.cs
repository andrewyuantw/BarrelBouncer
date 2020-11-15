using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource audioSource;
    private static AudioScript audioscript;

    public static AudioScript Instance
    {
        get { return audioscript; }
    }
    private void Awake()

    {
        if (audioscript != null && audioscript != this)
        {
            Destroy(this.gameObject);
            audioscript.raiseVolume();
            return;
        }
        audioscript = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void lowerVolume()

    {
        audioSource.volume = 0.1f;
    }

    public void raiseVolume()
    {
        audioSource.volume = 0.3f;
    }
    
    void Start()
    {
        audioSource.volume = 0.3f;
        audioSource.Play();
        MainMenuScript.onStartGame += lowerVolume;
    }

    void Update()
    {
        
    }
}
