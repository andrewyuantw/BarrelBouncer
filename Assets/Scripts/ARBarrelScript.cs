using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARBarrelScript : MonoBehaviour
{
    public AudioClip explodeSound;
    public GameObject plusOne;
    public GameObject explosion;
    public delegate void onBarrelHit();
    public static event onBarrelHit whenHit;

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
            AudioSource.PlayClipAtPoint(explodeSound, collision.contacts[0].point);
            whenHit();
            Instantiate(explosion, collision.contacts[0].point, Quaternion.identity);
            Instantiate(plusOne, collision.contacts[0].point, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
