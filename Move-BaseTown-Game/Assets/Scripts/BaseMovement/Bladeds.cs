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
    public GameObject blade7;
    public GameObject blade8;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationAmount = speed * rotationMultiplier * Time.deltaTime;
        BigRotateBlades(rotationAmount);
    }

    public void BigRotateBlades(float rotationAmount)
    {
        blade1.transform.Rotate(Vector3.forward, rotationAmount);
        blade2.transform.Rotate(Vector3.forward, rotationAmount);
        blade3.transform.Rotate(Vector3.forward, rotationAmount);
        blade4.transform.Rotate(Vector3.forward, rotationAmount);
        blade5.transform.Rotate(Vector3.forward, rotationAmount);
        blade6.transform.Rotate(Vector3.forward, rotationAmount);
        blade7.transform.Rotate(Vector3.forward, rotationAmount);
        blade8.transform.Rotate(Vector3.forward, rotationAmount);
    }
}
