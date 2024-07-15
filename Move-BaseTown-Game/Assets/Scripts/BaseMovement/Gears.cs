using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gears : MonoBehaviour
{
    public float speed = 1;
    public float rotationMultiplier = 10f;

    public GameObject Gear1;
    public GameObject Gear2;
    public GameObject Gear3;
    public GameObject Gear4;
    public GameObject Gear5;
    public GameObject Gear6;


    void Update()
    {
        float rotationAmount = speed * rotationMultiplier * Time.deltaTime;
        RotateVents(rotationAmount);
    }

    public void RotateVents(float rotationAmount)
    {
        Gear1.transform.Rotate(Vector3.back, rotationAmount);
        Gear2.transform.Rotate(Vector3.back, rotationAmount);
        Gear3.transform.Rotate(Vector3.back, rotationAmount);
        Gear4.transform.Rotate(Vector3.back, rotationAmount);
        Gear5.transform.Rotate(Vector3.back, rotationAmount);
        Gear6.transform.Rotate(Vector3.back, rotationAmount);
    }
}
