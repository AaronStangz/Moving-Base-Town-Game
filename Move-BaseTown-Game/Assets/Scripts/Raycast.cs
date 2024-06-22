using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private LayerMask Interactable;
    [SerializeField] private LayerMask Collectable;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main == null) return;

        RaycastHit hit;

        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 1000);
        if (Physics.SphereCast(ray, 0.5f, out hit, 10, Interactable + Collectable))
        {

            if (Interactable.value == (1 << hit.collider.gameObject.layer))
            {
                BaseConsole console = hit.collider.GetComponent<BaseConsole>();
                if (console != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < console.useRange)
                        {
                            Debug.Log("Driving");
                            console.drive();
                        }
                    }
                }

                Hub Gui = hit.collider.GetComponent<Hub>();
                if (Gui != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < Gui.useRange)
                        {
                            Debug.Log("Open GUI");
                            Gui.Open();
                        }
                    }
                }
            }



            if (Collectable.value == (1 << hit.collider.gameObject.layer))
            {
                Collect item = hit.collider.GetComponent<Collect>();
                if (item != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < item.pickUpRange)
                        {
                            Debug.Log("Collected");
                            item.CollectItem();
                        }
                    }
                }
            }

        }

        
    }
}
