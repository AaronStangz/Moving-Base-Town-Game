using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGlider : MonoBehaviour
{
    [Header("Float")]
    public float glideGravityModifier = 0.5f; // Multiplier to reduce gravity
    public float glideDrag = 2f; // Drag applied during gliding
    public float normalDrag = 0f; // Normal drag when not gliding
    public float glideSpeed = 10f; // Speed of forward movement while gliding
    public float turnSpeed = 50f; // Speed of turning while gliding
    public float steamPush = 1f; // Speed of turning while gliding


    [Header("Objects")]
    public Rigidbody rb;
    public GameObject playerCamera;
    public GameObject gliderCamera;
    public GameObject glider;

    [Header("Lean")]
    public GameObject Base;
    public float leanAngle = 30f;

    [Header("Bools")]
    public bool isGliding = false;
    public bool inSteam = false;

    void Start()
    {
        rb.drag = normalDrag;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && !isGliding && glider.activeSelf)
        {
            StartGlide();
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) && isGliding)
        {
            StopGlide();
        }

        if (isGliding)
        {
            TurnGlider();
        }
    }

    void FixedUpdate()
    {
        if (isGliding)
        {
            ApplyGlideGravity();
            GlideMovement();

            float leanHorizontal = Input.GetAxis("Horizontal");
            float leanVertical = Input.GetAxis("Vertical");

            float targetRotationHorizontal = leanHorizontal * leanAngle;
            float targetRotationVertical = leanVertical * leanAngle;

            Quaternion currentRotation = transform.rotation;
            Vector3 currentEulerAngles = currentRotation.eulerAngles;
            Quaternion newRotation = Quaternion.Euler(targetRotationVertical, currentEulerAngles.y, -targetRotationHorizontal);

            transform.rotation = newRotation;
        }
    }

    public void StartGlide()
    {
        playerCamera.SetActive(false);
        gliderCamera.SetActive(true);
        gameObject.GetComponent<PlayerMovement>().enabled = false;
        isGliding = true;
        rb.drag = glideDrag; // Increase drag to slow down falling
    }

    public void StopGlide()
    {
        playerCamera.SetActive(true);
        gliderCamera.SetActive(false);
        gameObject.GetComponent<PlayerMovement>().enabled = true;
        isGliding = false;
        transform.rotation = new Quaternion(0, 0, 0, 0);
        rb.drag = normalDrag; // Reset drag to normal
    }

    void ApplyGlideGravity()
    {
        // Apply reduced gravity while gliding
        Vector3 glideForce = Physics.gravity * (1 - glideGravityModifier);
        rb.AddForce(glideForce, ForceMode.Acceleration);
    }

    void GlideMovement()
    {
        // Handle forward movement
        rb.AddForce(transform.forward * glideSpeed, ForceMode.Acceleration);
    }

    void TurnGlider()
    {
        float turnInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnInput * turnSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Steam"))
        {
            inSteam = true;
            glideGravityModifier = steamPush;
        }
        else if(!other.CompareTag("Steam"))
        {
            inSteam = false;
            glideGravityModifier = 1.8f;
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Steam"))
        {
            inSteam = false;
            glideGravityModifier = 1.8f;
        }
    }
}