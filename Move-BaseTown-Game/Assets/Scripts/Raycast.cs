using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private LayerMask Interactable;
    [SerializeField] private LayerMask Collectable;

    ItemManager IM;
    Inventory INV;
    public GameObject mainManger;
    public GameObject player;

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
        INV = player.GetComponent<Inventory>();

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

                FillBuild Build = hit.collider.GetComponent<FillBuild>();
                if (Build != null)
                {
                    if (Input.GetKeyDown(KeyCode.E) && INV.HoldingScrapWood == true && IM.scrapWood >= 0)
                    {
                        if (hit.distance < Build.useRange)
                        {
                            Debug.Log("Build");
                            Build.PlaceScrapWood();
                            IM.scrapWood -= 1;
                            IM.townCurrentLevelPoints += 5;
                            if(IM.scrapWood == 0)
                            {
                                INV.OpenHand = true;
                            }
                        }
                    }

                    if (Input.GetKeyDown(KeyCode.E) && INV.HoldingLightWood == true && IM.lightWood >= 0)
                    {
                        if (hit.distance < Build.useRange)
                        {
                            Debug.Log("Build");
                            Build.PlaceLightWood();
                            IM.lightWood -= 1;
                            IM.townCurrentLevelPoints += 10;
                            if (IM.lightWood == 0)
                            {
                                INV.OpenHand = true;
                            }
                        }
                    }

                    if (Input.GetKeyDown(KeyCode.E) && INV.HoldingHeavyWood == true && IM.heavyWood >= 0)
                    {
                        if (hit.distance < Build.useRange)
                        {
                            Debug.Log("Build");
                            Build.PlaceHeavyWood();
                            IM.heavyWood -= 1;
                            IM.townCurrentLevelPoints += 20;
                            if (IM.heavyWood == 0)
                            {
                                INV.OpenHand = true;
                            }
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
