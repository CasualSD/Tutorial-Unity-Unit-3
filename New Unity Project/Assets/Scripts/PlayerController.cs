using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {

        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerRb.freezeRotation = true; 

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;

        }

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.name == "Ground")
        {

            isGrounded = true;

        }

    }
}
