using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;

    public Transform Orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 MoveDirection;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }


    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }


    private void MovePlayer()
    {
        // Calculate movement direction
        MoveDirection = Orientation.forward * verticalInput + Orientation.right * horizontalInput;
        rb.AddForce(MoveDirection.normalized * MoveSpeed * 10f, ForceMode.Force);
    }
}

