using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor.Timeline.Actions;

public class Inventory : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject invCamera;
    public GameObject inventory;
    public GameObject inventoryGui;
    public GameObject mainManger;
    ItemManager IM;

    public TMP_Text[] ItemText;
    public GameObject[] HoldItems;

    public bool HoldingScrapWood;
    public bool HoldingLightWood;
    public bool HoldingHeavyWood;
    public bool HoldingGlider;

    public GameObject OnHandScrapWood;
    public GameObject OnHandLightWood;
    public GameObject OnHandHeavyWood;
    public GameObject OnHandGlider;

    public bool OpenHand;

    public bool invOpen;

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
    }

    public void UpgradeText()
    {
        ItemText[0].text = "Scrap Metel: " + IM.scrapMetel + " / " + "20";
        ItemText[1].text = "Light Metel: " + IM.lightMetel + " / " + "20";
        ItemText[2].text = "Heavy Metel: " + IM.heavyMetel + " / " + "20";
        ItemText[3].text = "Scrap Wood: " + IM.scrapWood + " / " + "20";
        ItemText[4].text = "Light Wood: " + IM.lightWood + " / " + "20";
        ItemText[5].text = "Heavy Wood: " + IM.heavyWood + " / " + "20";
        ItemText[6].text = "Glider";
    }

    void Update()
    {
        if (invOpen)
        {
            UpgradeText();
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                mainCamera.SetActive(true);
                invCamera.SetActive(false);
                inventory.SetActive(false);
                inventoryGui.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                invOpen = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            mainCamera.SetActive(false);
            invCamera.SetActive(true);
            inventory.SetActive(true);
            inventoryGui.SetActive(true);
            invOpen = true;
            Cursor.lockState = CursorLockMode.None;
            OpenHand = true;
        }

        if (OpenHand == true)
        {
            HoldingScrapWood = false;
            OnHandScrapWood.SetActive(false);
            HoldingLightWood = false;
            OnHandLightWood.SetActive(false);
            HoldingHeavyWood = false;
            OnHandHeavyWood.SetActive(false);
            HoldingGlider = false;
            OnHandGlider.SetActive(false);
        }
    }

    public void ForceClose()
    {
        if (invOpen)
        {
            mainCamera.SetActive(true);
            invCamera.SetActive(false);
            inventory.SetActive(false);
            inventoryGui.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            invOpen = false;
        }
    }

    public void HoldScrapWood()
    {
        print("Holding");
            OpenHand = false;
            HoldingScrapWood = true;
            OnHandScrapWood.SetActive(true);
            ForceClose();
    }
    public void HoldLightWood()
    {
            OpenHand = false;
            HoldingLightWood = true;
            OnHandLightWood.SetActive(true);
            ForceClose();
    }
    public void HoldHeavyWood()
    {
            OpenHand = false;
            HoldingHeavyWood = true;
            OnHandHeavyWood.SetActive(true);
            ForceClose();
    }
    public void HoldGlider()
    {
        OpenHand = false;
        HoldingGlider = true;
        OnHandGlider.SetActive(true);
        ForceClose();
    }
}
