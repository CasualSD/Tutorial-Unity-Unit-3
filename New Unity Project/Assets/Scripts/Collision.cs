using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private Rigidbody rb;
    private massPlayer = 2f;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.name == "Obstacle")
        {

            rb.mass = massPlayer;
            rb.useGravity = false;

        }
    }
}
