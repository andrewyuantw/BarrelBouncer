using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoCreation : MonoBehaviour
{
    public float timeRemaining = 10;
    public GameObject ammoBarrel;
    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            timeRemaining = 5;
            System.Random random = new System.Random();
            int randomAngle = random.Next(360);

            Instantiate(ammoBarrel, player.position - new Vector3(0f, 1f, 0f) + (Quaternion.AngleAxis(randomAngle, Vector3.up) * new Vector3(20f, 0f, 0f)), Quaternion.identity);
        }
    }
}
