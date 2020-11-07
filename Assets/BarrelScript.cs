using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelScript : MonoBehaviour
{
    public AudioClip explodeSound;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I am being hit");
        if (collision.gameObject.tag == "Ball")
        {
            AudioSource.PlayClipAtPoint(explodeSound, gameObject.transform.position);
            //GameObject explode = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            //explode.GetComponent<ParticleSystem>().Play();
            Destroy(gameObject);

        }
    }
}
