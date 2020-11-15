using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public AudioClip bounceNoise;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Destroy(gameObject, 5);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Barrel")
        {
            AudioSource.PlayClipAtPoint(bounceNoise, collision.contacts[0].point);
        }
    }

}
