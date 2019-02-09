using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector]public Rigidbody2D rigidBody;
    public float speed;
    public float rotationSpeed;

	// Use this for initialization
	void Start ()
    {
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //Moving Forward
        if(Input.GetKey(KeyCode.UpArrow))
        {
            //Move the player forward
            rigidBody.AddForce(transform.up * speed);
        }
        //Turning Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate CCW
            transform.Rotate(transform.forward * rotationSpeed);
        }
        //Turning Right
        if(Input.GetKey(KeyCode.RightArrow))
        {
            //Rotate CW
            transform.Rotate(-transform.forward * rotationSpeed);
        }
    }
}
