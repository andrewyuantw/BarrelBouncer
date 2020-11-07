using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public AudioClip bounceNoise;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ball hit");
        if (collision.gameObject.tag != "Barrel")
        {
            AudioSource.PlayClipAtPoint(bounceNoise, collision.contacts[0].point);
            

        }
    }

}
