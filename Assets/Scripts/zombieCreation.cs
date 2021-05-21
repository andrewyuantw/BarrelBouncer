using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieCreation : MonoBehaviour
{
    public float timeRemaining = 5;
    public GameObject zombie;
    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0) {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            timeRemaining = 5;
            System.Random random = new System.Random();
            int randomAngle = random.Next(360);

            Instantiate(zombie, player.position + (Quaternion.AngleAxis(randomAngle, Vector3.up) * new Vector3(20f, 0f, 0f)), Quaternion.identity);
        }
        
        
    }
}
