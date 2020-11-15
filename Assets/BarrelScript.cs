using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BarrelScript : MonoBehaviour
{
    public AudioClip explodeSound;
    public delegate void onBarrelHit();
    public static event onBarrelHit whenHit;
    public GameObject plusOne;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            AudioSource.PlayClipAtPoint(explodeSound, gameObject.transform.position);
            whenHit();
            Instantiate(plusOne, collision.contacts[0].point + new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
