using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping : MonoBehaviour
{
	private bool isGrounded = true;
    
    void Start()
    {
        
    }
     void OnTriggerStay(Collider other)
    {
        if (other.tag != "Player"){
            isGrounded = true;
        }
    }
    void  OnTriggerExit(){
    	isGrounded = false;
    }

    void Update()
    {
        
    }
    public bool getGrounded(){
    	return isGrounded;
    }
}
