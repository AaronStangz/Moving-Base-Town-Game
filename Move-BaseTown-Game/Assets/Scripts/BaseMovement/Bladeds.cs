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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationAmount = speed * rotationMultiplier * Time.deltaTime;
        BigRotateBlades(rotationAmount);
        MidRotateBlades(rotationAmount);
    }

    public void BigRotateBlades(float rotationAmount)
    {
        blade1.transform.Rotate(Vector3.forward, rotationAmount);
        blade2.transform.Rotate(Vector3.forward, rotationAmount);
    }

    public void MidRotateBlades(float rotationAmount)
    {
        blade3.transform.Rotate(Vector3.forward, rotationAmount * 2);
        blade4.transform.Rotate(Vector3.forward, rotationAmount * 2);
    }

}
