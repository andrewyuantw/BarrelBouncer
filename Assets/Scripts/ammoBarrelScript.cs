using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ammoBarrelScript : MonoBehaviour
{
    public delegate void onAmmoHit();
    public static event onAmmoHit whenHit;
    
    public int randomNum;
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
        if (collision.gameObject.tag == "Player")
        {
            whenHit();
            Destroy(gameObject);
        }
    }
}
