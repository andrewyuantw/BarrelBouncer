using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelScript : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        Transform playertrans = player.GetComponent<Transform>();
        transform.LookAt(playertrans);
        transform.localRotation *= Quaternion.Euler(0, 180, 0);
    }
}
