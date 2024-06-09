using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    [Header("Moving")]
    public float rotationMultiplier = 10f;
    public float speed = 5f;
    public float smallWheelSpeed = 10f;
    public float bigWheelSpeed = 20f;
    public float maxSpeed = 10f;
    public Rigidbody rb;
    public LayerMask groundLayer;
    public float smallWheelGroundCheckDistance;
    public float BigWheelGroundCheckDistance;

    [Header("Turning")]
    public float maxSteerAngle = 0.1f;
    public float rotationSpeed = 1;

    [Header("Wheels")]
    public GameObject leftWheel;
    public GameObject rightWheel;
    public GameObject leftMainWheel;
    public GameObject rightMainWheel;

    [Header("WheelsGrounded")]
    public bool leftWheelGrounded;
    public bool rightWheelGrounded;
    public bool leftMainWheelGrounded;
    public bool rightMainWheelGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        leftWheelGrounded = false;
        rightWheelGrounded = false;
        leftMainWheelGrounded = false;
        rightMainWheelGrounded = false;


    }


    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
        Turn();
        CheckGround();
    }

    //Wheels Ground
    void CheckGround()
    {
        RaycastHit hit;
        if (Physics.Raycast(leftWheel.transform.position, Vector3.down, out hit, smallWheelGroundCheckDistance, groundLayer))
        {
            leftWheelGrounded = true;
        }
        else
        {
            leftWheelGrounded = false;
        }

        if (Physics.Raycast(rightWheel.transform.position, Vector3.down, out hit, smallWheelGroundCheckDistance, groundLayer))
        {
            rightWheelGrounded = true;
        }
        else
        {
            rightWheelGrounded = false;
        }

        if (Physics.Raycast(leftMainWheel.transform.position, Vector3.down, out hit, BigWheelGroundCheckDistance, groundLayer))
        {
            leftMainWheelGrounded = true;
        }
        else
        {
            leftMainWheelGrounded = false;
        }

        if (Physics.Raycast(rightMainWheel.transform.position, Vector3.down, out hit, BigWheelGroundCheckDistance, groundLayer))
        {
            rightMainWheelGrounded = true;
        }
        else
        {
            rightMainWheelGrounded = false;
        }
    }

    void Move()
    {
        float rotationAmount = speed * rotationMultiplier * Time.deltaTime;

        //Driveing
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed * 100);
            ForwardRotateWheels(rotationAmount);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * speed * 0.5f * 100);
            BackRotateWheels(rotationAmount);
        }

        if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.A)))
        {
            rightMainWheel.transform.Rotate(Vector3.back, rotationAmount * 1f);
        }
        if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.D)))
        {
            leftMainWheel.transform.Rotate(Vector3.back, rotationAmount * 1);
        }

        //Speed Manage
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        if (speed >= maxSpeed)
        {
            speed = maxSpeed;
        }
        if (speed <= -1)
        {
            speed += 5;
        }
        if ((rightMainWheelGrounded == true) && (leftMainWheelGrounded == true))
        {
            speed += 15;
        }
        if ((rightMainWheelGrounded == false) && (leftMainWheelGrounded == false))
        {
            speed -= 15;
        }
        if ((rightWheelGrounded == true) && (leftWheelGrounded == true))
        {
            speed += 10;
        }
        if ((rightWheelGrounded == false) && (leftWheelGrounded == false))
        {
            speed -= 10;
        }
    }

    //Wheels Spinning
    void ForwardRotateWheels(float rotationAmount)
    {
        leftWheel.transform.Rotate(Vector3.forward, rotationAmount);
        rightWheel.transform.Rotate(Vector3.forward, rotationAmount);

        leftMainWheel.transform.Rotate(Vector3.forward, rotationAmount);
        rightMainWheel.transform.Rotate(Vector3.forward, rotationAmount);
    }

    void BackRotateWheels(float rotationAmount)
    {
        leftWheel.transform.Rotate(Vector3.back, rotationAmount);
        rightWheel.transform.Rotate(Vector3.back, rotationAmount);

        leftMainWheel.transform.Rotate(Vector3.forward, rotationAmount);
        rightMainWheel.transform.Rotate(Vector3.forward, rotationAmount);
    }

    //Truning
    void Turn()
    {
        if (Input.GetKey(KeyCode.W) && (leftMainWheelGrounded == true))
        {

            float horizontalInput = Input.GetAxis("Horizontal");
            float steerAngle = horizontalInput * maxSteerAngle;
            Quaternion rotation = Quaternion.Euler(0f, steerAngle, 0f);
            rb.MoveRotation(rb.rotation * rotation);
        }

       
    }
}
