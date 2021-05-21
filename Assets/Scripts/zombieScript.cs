using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieScript : MonoBehaviour
{
    public Rigidbody target;
    public delegate void onZombieHit();
    public static event onZombieHit whenHit;
    public GameObject explosion;
    public GameObject plusOne;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, 0.01f);
        Transform playertrans = target.GetComponent<Transform>();
        transform.LookAt(playertrans);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            
            whenHit();
            Instantiate(explosion, collision.contacts[0].point + new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);
            Instantiate(plusOne, collision.contacts[0].point + new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
