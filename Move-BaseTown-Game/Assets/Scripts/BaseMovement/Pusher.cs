using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    public float speed = 1;
    public float rotationMultiplier = 10f;

    public GameObject pusher1;
    public GameObject pusher2;
    public GameObject pusher3;
    public GameObject pusher4;
    public GameObject pusher5;
    public GameObject pusher6;
    public GameObject pusher7;
    public GameObject pusher8;

    void Update()
    {
        float rotationAmount = speed * rotationMultiplier * Time.deltaTime;
        RotateVents(rotationAmount);
    }

    public void RotateVents(float rotationAmount)
    {
        pusher1.transform.Rotate(Vector3.back, rotationAmount);
        pusher2.transform.Rotate(Vector3.back, rotationAmount);
        pusher3.transform.Rotate(Vector3.back, rotationAmount);
        pusher4.transform.Rotate(Vector3.back, rotationAmount);
        pusher5.transform.Rotate(Vector3.back, rotationAmount);
        pusher6.transform.Rotate(Vector3.back, rotationAmount);
        pusher7.transform.Rotate(Vector3.back, rotationAmount);
        pusher8.transform.Rotate(Vector3.back, rotationAmount);
    }
}
