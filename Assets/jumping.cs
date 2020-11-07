using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping : MonoBehaviour
{
	private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     void OnTriggerStay(Collider other)
    {
        
        if (other.tag != "Player"){
            isGrounded = true;
            Debug.Log("on ground rn");
        }
        
    }
    void  OnTriggerExit(){
    	Debug.Log("left ground rn");
    	isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool getGrounded(){
    	return isGrounded;
    }
}
