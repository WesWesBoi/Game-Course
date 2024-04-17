using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayMove : MonoBehaviour
{
    Rigidbody playerRB;
    float movementSpeed = 6f;
    float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Rigidbody playerRB.velocity = new Vector3(horizontalInput * movementSpeed, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            playerRB.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            //transform.Translate(0, jumpHeight *Time.deltaTime, 0);
        }
    }

}