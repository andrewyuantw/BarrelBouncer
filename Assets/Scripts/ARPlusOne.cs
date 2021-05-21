using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARPlusOne : MonoBehaviour
{
    public GameObject player;
    
    void Start()
    {
        player = Camera.main.gameObject;
        Destroy(this.gameObject, 2);
    }

    
    void Update()
    {
        Transform playertrans = player.GetComponent<Transform>();
        transform.LookAt(playertrans);
        transform.localRotation *= Quaternion.Euler(0, 180, 0);

    }
}
