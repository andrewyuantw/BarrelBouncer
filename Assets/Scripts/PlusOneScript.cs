using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusOneScript : MonoBehaviour
{
    public GameObject player;
    
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    
    void Update()
    {
        Transform playertrans = player.GetComponent<Transform>();
        transform.LookAt(playertrans);
        transform.localRotation *= Quaternion.Euler(0, 180, 0);
        Destroy(gameObject, 2);
    }
}
