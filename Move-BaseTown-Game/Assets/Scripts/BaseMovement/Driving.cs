using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Driving : MonoBehaviour
{
    [Header("Moving")]
    public float speed = 1;
    public float maxSpeed = 10f;
    public float Gravity = 10f;
    public GameObject basetown;
    public GameObject mainManager;
    public GameObject baseconsole;
    public Rigidbody rb;
    public LayerMask groundLayer;


    [Header("Particle")]
    public ParticleSystem leftWheelPS;
    public ParticleSystem middelWheelPS;
    public ParticleSystem rightWheelPS;
    public ParticleSystem leftMainWheelPS;
    public ParticleSystem rightMainWheelPS;

    [Header("Turning")]
    public float maxSteerAngle = 0.1f;
    public float rotationSpeed = 1;

    [Header("Wheels")]
    public float rotationMultiplier = 10f;
    public GameObject leftWheel;
    public GameObject middelWheel;
    public GameObject rightWheel;
    public GameObject leftMainWheel;
    public GameObject rightMainWheel;

    [Header("WheelsGrounded")]
    public Collider frontWheels;
    public Collider backWheels;
    public float frontWheelGroundCheckDistance;
    public float backWheelGroundCheckDistance;
    public bool frontWheelGrounded;
    public bool backWheelGrounded;

    void Start()
    {
        
        
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            BaseConsole console = baseconsole.GetComponent<BaseConsole>();
            console.exitdrive();
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Turn();
        CheckGround();
        rb.AddRelativeForce(Vector3.down * Gravity * 500);
    }
    public void Move()
    {
        float rotationAmount = speed * rotationMultiplier * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed * 1000);
            ForwardRotateWheels(rotationAmount);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * speed * 0.5f * 1000);
            BackRotateWheels(rotationAmount);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            speed = 0;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rightMainWheel.transform.Rotate(Vector3.back, rotationAmount * -2f);
            leftMainWheel.transform.Rotate(Vector3.back, rotationAmount * 2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            leftMainWheel.transform.Rotate(Vector3.back, rotationAmount * -2f);
            rightMainWheel.transform.Rotate(Vector3.back, rotationAmount * 2f);
        }
    }

    void Turn()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float steerAngle = horizontalInput * maxSteerAngle;
        Quaternion rotation = Quaternion.Euler(0f, steerAngle, 0f);
        rb.MoveRotation(rb.rotation * rotation);
    }

    public void ForwardRotateWheels(float rotationAmount)
    {
        leftWheel.transform.Rotate(Vector3.forward, rotationAmount);
        middelWheel.transform.Rotate(Vector3.forward, rotationAmount);
        rightWheel.transform.Rotate(Vector3.forward, rotationAmount);


        leftMainWheel.transform.Rotate(Vector3.forward, rotationAmount);
        rightMainWheel.transform.Rotate(Vector3.forward, rotationAmount);
    }

    public void BackRotateWheels(float rotationAmount)
    {
        leftWheel.transform.Rotate(Vector3.back, rotationAmount);
        middelWheel.transform.Rotate(Vector3.back, rotationAmount);
        rightWheel.transform.Rotate(Vector3.back, rotationAmount);

        leftMainWheel.transform.Rotate(Vector3.forward, rotationAmount);
        rightMainWheel.transform.Rotate(Vector3.forward, rotationAmount);
    }

    void CheckGround()
    {

            RaycastHit hit;
            if (Physics.Raycast(leftMainWheel.transform.position, Vector3.down, out hit, frontWheelGroundCheckDistance, groundLayer))
            {
                frontWheelGrounded = true;
                if (Input.GetKey(KeyCode.W))
                {
                    leftMainWheelPS.Play();
                }
            }
            else
            {
                frontWheelGrounded = false;
            }

            if (Physics.Raycast(backWheels.transform.position, Vector3.down, out hit, backWheelGroundCheckDistance, groundLayer))
            {
                backWheelGrounded = true;
                if (Input.GetKey(KeyCode.W))
                {

                }
            }
            else
            {
                backWheelGrounded = false;
            }

    }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Rock")
            {
                Debug.Log("Hit Rock");
                GameObject.Destroy(gameObject);
            }
        }
    
}
