using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpPower = 5f;
    public float moveSpeed = 10f;
    public LayerMask playerMask;
    public LayerMask groundLayer = 10;

    private bool grounded;

    private BoxCollider capsuleCollider;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;



    // Start is called before the first frame update
    void Start()
    {
        
        rigidbodyComponent = GetComponent<Rigidbody>();
        capsuleCollider = GetComponent<BoxCollider>();
        //groundLayer.value = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
        horizontalInput = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        rigidbodyComponent.velocity = new Vector3(horizontalInput * moveSpeed, rigidbodyComponent.velocity.y, 0);

        if (jumpKeyWasPressed)
        {
            if (grounded)
            {
                rigidbodyComponent.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                grounded = false;
                jumpKeyWasPressed = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 10 || collision.gameObject.layer == 7)
        {
            grounded = true;
            
        }

    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.gameObject.layer == 1)
    //    {
    //        Destroy(other.gameObect);
    //    }
    //}
}
