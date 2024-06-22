using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject invCamera;
    public GameObject inventory;

    public bool invOpen;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            mainCamera.SetActive(false);
            invCamera.SetActive(true);
            inventory.SetActive(true);
            invOpen = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && (invOpen == true))
        {
            mainCamera.SetActive(true);
            invCamera.SetActive(false);
            inventory.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            invOpen = false;
        }
    }
}
