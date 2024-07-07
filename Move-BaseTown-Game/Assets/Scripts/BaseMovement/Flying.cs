using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Flying : MonoBehaviour
{
    public GameObject baseconsole;

    public float propellerspeed = 1;
    public float rotationMultiplier = 10f;

    public GameObject propeller1;
    public GameObject propeller2;

    [Header("Moving")]
    public float speed = 1;
    public float maxSpeed = 10f;
    public Rigidbody rb;

    [Header("Turning")]
    public float maxSteerAngle = 0.1f;
    public float rotationSpeed = 1;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BaseConsole Console = baseconsole.GetComponent<BaseConsole>();
            print("Exit");
            Console.exitdrive();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Turn();
    }

    public void Move()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        float rotationAmount = propellerspeed * rotationMultiplier * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed * 1000);
            propellerspeed = 20;
            RotatePropellerForwards(rotationAmount);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * speed * 0.5f * 1000);
            propellerspeed = 20;
            RotatePropellerBackwards(rotationAmount);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
            { propellerspeed = 1; }
    }

    void Turn()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float steerAngle = horizontalInput * maxSteerAngle;
        Quaternion rotation = Quaternion.Euler(0f, steerAngle, 0f);
        rb.MoveRotation(rb.rotation * rotation);
    }

    public void RotatePropellerBackwards(float rotationAmount)
    {
        propeller1.transform.Rotate(Vector3.back, rotationAmount);
        propeller2.transform.Rotate(Vector3.back, rotationAmount);
    }
    public void RotatePropellerForwards(float rotationAmount)
    {
        propeller1.transform.Rotate(Vector3.forward, rotationAmount);
        propeller2.transform.Rotate(Vector3.forward, rotationAmount);
    }
}
