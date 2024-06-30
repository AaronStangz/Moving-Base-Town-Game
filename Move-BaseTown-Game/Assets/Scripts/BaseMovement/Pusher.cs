using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    public float speed = 1;
    public float rotationMultiplier = 10f;

    public GameObject pusher1;
    public GameObject pusher2;

    void Update()
    {
        float rotationAmount = speed * rotationMultiplier * Time.deltaTime;
        RotateVents(rotationAmount);
    }

    public void RotateVents(float rotationAmount)
    {
        pusher1.transform.Rotate(Vector3.back, rotationAmount);
        pusher2.transform.Rotate(Vector3.back, rotationAmount);
    }
}
