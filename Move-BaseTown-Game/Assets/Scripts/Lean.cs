using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lean : MonoBehaviour
{
    public GameObject Base;
    public float leanAngle = 30f;

    void Start()
    {

    }

    void Update()
    {
        if (Base.GetComponent<Flying>().enabled == true)
        {
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
}
