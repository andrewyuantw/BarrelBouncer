using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float translationalSpeed = 1.0f, rotationalSpeed = 5.0f;
	public Transform cameraTransform;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	cameraTransform.Rotate(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X") * rotationalSpeed, 0);
    	Vector3 direction = Vector3.zero; 

        if (Input.GetKey(KeyCode.S))
        {
            direction -= cameraTransform.forward;
        }
        if (Input.GetKey(KeyCode.W))
        {
			direction += cameraTransform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += cameraTransform.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction -= cameraTransform.right;
        }
        direction.y = 0f;
        transform.position += direction * Time.deltaTime * translationalSpeed;
        

        



    }
}
