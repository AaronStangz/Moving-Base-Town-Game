using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bladeds : MonoBehaviour
{
    public float speed = 1;
    public float rotationMultiplier = 10f;

    public GameObject blade1;
    public GameObject blade2;
    public GameObject blade3;
    public GameObject blade4;
    public GameObject blade5;
    public GameObject blade6;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationAmount = speed * rotationMultiplier * Time.deltaTime;
        BigRotateBlades(rotationAmount);
        MidRotateBlades(rotationAmount);
        SmallRotateBlades(rotationAmount);
    }

    public void BigRotateBlades(float rotationAmount)
    {
        blade1.transform.Rotate(Vector3.back, rotationAmount);
        blade2.transform.Rotate(Vector3.back, rotationAmount);
    }

    public void MidRotateBlades(float rotationAmount)
    {
        blade3.transform.Rotate(Vector3.back, rotationAmount * 5);
        blade4.transform.Rotate(Vector3.back, rotationAmount * 5);
    }

    public void SmallRotateBlades(float rotationAmount)
    {
        blade5.transform.Rotate(Vector3.back, rotationAmount * 10);
        blade6.transform.Rotate(Vector3.back, rotationAmount * 10);
    }
}
