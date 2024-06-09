using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseConsole : MonoBehaviour
{
    public float useRange;

    public GameObject Player;
    public GameObject Base;
    public GameObject DriveCam;
    public Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void drive()
    {
        Player.SetActive(false);
        DriveCam.SetActive(true);
        Base.GetComponent<BaseMovement>().enabled = true;


    }
}
