using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class BaseConsole : MonoBehaviour
{
    public float useRange;

    public GameObject Player;
    public GameObject mainManager;
    public GameObject Base;
    public GameObject DriveCam;
    public Rigidbody rb;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void drive()
    {
        Player.SetActive(false);
        DriveCam.SetActive(true);
        Base.GetComponent<Flying>().enabled = true;
        Player.transform.parent = null;
        ItemManager Item = mainManager.GetComponent<ItemManager>();
        Player.transform.parent = Item.playerSpawn.transform;
    }
    public void exitdrive()
    {
        print("Exiting");
        Player.SetActive(true);
        DriveCam.SetActive(false);
        Base.GetComponent<Flying>().enabled = false;
        Player.transform.parent = null;
    }
}
