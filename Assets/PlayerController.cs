using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float translationalSpeed = 1.0f, rotationalSpeed = 5.0f;
	public Transform cameraTransform;
    public Vector3 direction = Vector3.zero;
    public Rigidbody rb;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    public GameObject myBarrel;
    public GameObject myBall;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    { 
        yaw += rotationalSpeed * Input.GetAxis("Mouse X");
        pitch -= rotationalSpeed * Input.GetAxis("Mouse Y");
        cameraTransform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        direction = Input.GetAxis("Horizontal") * cameraTransform.right + Input.GetAxis("Vertical") * cameraTransform.forward;
        
        bool isGrounded = GameObject.Find("Feet").GetComponent<jumping>().getGrounded();
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
            rb.AddForce(new Vector3(0.0f, 50.0f, 0.0f), ForceMode.Impulse);
        }

        RaycastHit hit;
        Debug.DrawRay(cameraTransform.position, cameraTransform.forward * 1000, Color.green);
        if(Input.GetMouseButtonDown(1)){
            if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit, Mathf.Infinity)){
                Instantiate(myBarrel, hit.point + new Vector3(0 , 1, 0), Quaternion.identity);   
            }
        }

        if (Input.GetMouseButtonDown(0)){
            GameObject ball = Instantiate(myBall, cameraTransform.position + cameraTransform.forward, Quaternion.identity);
        	ball.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * 25.0f, ForceMode.Impulse);
        }
    }

    void OnTriggerEnter(Collider other)
    {   
        if (other.tag == "TriggerOfDeath"){
            Debug.Log("touching trigger");
            transform.position = new Vector3(0, 5,0);
            transform.rotation = Quaternion.identity;
        }
            
    } 

    void FixedUpdate(){
        Vector3 movement = direction * translationalSpeed;
        movement.y = rb.velocity.y;
        rb.velocity = movement;

    }

      
    
    
}
