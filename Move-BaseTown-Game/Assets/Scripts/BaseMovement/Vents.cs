using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vents : MonoBehaviour
{
    public float speed = 1;
    public float rotationMultiplier = 10f;

    public GameObject Vent1;
    public GameObject Vent2;

    void Update()
    {
        float rotationAmount = speed * rotationMultiplier * Time.deltaTime;
        RotateVents(rotationAmount);
    }

    public void RotateVents(float rotationAmount)
    {
        Vent1.transform.Rotate(Vector3.back, rotationAmount);
        Vent2.transform.Rotate(Vector3.back, rotationAmount);
    }
}
