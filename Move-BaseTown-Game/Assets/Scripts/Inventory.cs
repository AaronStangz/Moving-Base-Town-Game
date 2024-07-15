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

    public GameObject[] scrapSteelItem;
    public GameObject[] scrapWoodItem;
    public GameObject[] scrapCopperItem;

    public GameObject[] steelItem;
    public GameObject[] woodItem;
    public GameObject[] copperItem;

    public GameObject[] steelRodItem;
    public GameObject[] woodRodItem;
    public GameObject[] steelbeamItem;
    public GameObject[] copperWireItem;
    public GameObject[] steelPlateItem;
    public GameObject[] steelCableItem;

    public GameObject[] screwsItem;
    public GameObject[] gearItem;

    public bool HoldingScrapWood;
    public GameObject OnHandScrapWood;

    public bool OpenHand;

    public bool invOpen;

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
    }

    public void UpgradeText()
    {

            ItemText[0].text = "Scrap Steel: " + IM.scrapSteel + " / " + "20";
            ItemText[1].text = "Scrap Wood: " + IM.scrapWood + " / " + "20";
            ItemText[2].text = "Scrap Copper: " + IM.scrapCopper + " / " + "20";

            ItemText[3].text = "Steel: " + IM.steel + " / " + "20";
            ItemText[4].text = "Wood: " + IM.wood + " / " + "20";
            ItemText[5].text = "Copper " + IM.copper + " / " + "20";

            ItemText[6].text = "Steel Rod: " + IM.steelRod + " / " + "20";
            ItemText[7].text = "Wood Rod: " + IM.woodRod + " / " + "20";
            ItemText[8].text = "Steal Beam: " + IM.steelbeam + " / " + "20";
            ItemText[9].text = "Copper Wire: " + IM.copperWire + " / " + "20";
            ItemText[10].text = "Steel Plate: " + IM.steelPlate + " / " + "20";
            ItemText[11].text = "Steel Cable: " + IM.steelCable + " / " + "20";

            ItemText[12].text = "Screws: " + IM.screws + " / " + "20";
            ItemText[13].text = "Gears: " + IM.gear + " / " + "20";     
    }

    void Update()
    {
        if (invOpen == true)
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

            if (IM.scrapSteel >= 0)
            {
                scrapSteelItem[0].SetActive(false);
                ItemText[0].gameObject.SetActive(false);
            }

            if (IM.scrapSteel >= 1)
            {
                scrapSteelItem[0].SetActive(true);
                ItemText[0].gameObject.SetActive(true);
            }

            if (IM.scrapWood >= 0)
            {
                scrapWoodItem[0].SetActive(false);
                ItemText[1].gameObject.SetActive(false);
            }

            if (IM.scrapWood >= 1)
            {
                scrapWoodItem[0].SetActive(true);
                ItemText[1].gameObject.SetActive(true);
            }

            if (IM.scrapCopper >= 0)
            {
                scrapCopperItem[0].SetActive(false);
                ItemText[2].gameObject.SetActive(false);
            }

            if (IM.scrapCopper >= 1)
            {
                scrapCopperItem[0].SetActive(true);
                ItemText[2].gameObject.SetActive(true);
            }

            if (IM.steel >= 0)
            {
                steelItem[0].SetActive(false);
                ItemText[3].gameObject.SetActive(false);
            }

            if (IM.steel >= 1)
            {
                steelItem[0].SetActive(true);
                ItemText[3].gameObject.SetActive(true);
            }

            if (IM.wood >= 0)
            {
                woodItem[0].SetActive(false);
                ItemText[4].gameObject.SetActive(false);
            }

            if (IM.wood >= 1)
            {
                woodItem[0].SetActive(true);
                ItemText[4].gameObject.SetActive(true);
            }

            if (IM.copper >= 0)
            {
                copperItem[0].SetActive(false);
                ItemText[5].gameObject.SetActive(false);
            }

            if (IM.copper >= 1)
            {
                copperItem[0].SetActive(true);
                ItemText[5].gameObject.SetActive(true);
            }

            if (IM.steelRod >= 0)
            {
                steelRodItem[0].SetActive(false);
                ItemText[6].gameObject.SetActive(false);
            }

            if (IM.steelRod >= 1)
            {
                steelRodItem[0].SetActive(true);
                ItemText[6].gameObject.SetActive(true);
            }

            if (IM.woodRod >= 0)
            {
                woodRodItem[0].SetActive(false);
                ItemText[7].gameObject.SetActive(false);
            }

            if (IM.woodRod >= 1)
            {
                woodRodItem[0].SetActive(true);
                ItemText[7].gameObject.SetActive(true);
            }

            if (IM.steelbeam >= 0)
            {
                steelbeamItem[0].SetActive(false);
                ItemText[8].gameObject.SetActive(false);
            }

            if (IM.steelbeam >= 1)
            {
                steelbeamItem[0].SetActive(true);
                ItemText[8].gameObject.SetActive(true);
            }

            if (IM.copperWire >= 0)
            {
                copperWireItem[0].SetActive(false);
                ItemText[9].gameObject.SetActive(false);
            }

            if (IM.copperWire >= 1)
            {
                copperWireItem[0].SetActive(true);
                ItemText[9].gameObject.SetActive(true);
            }

            if (IM.steelPlate >= 0)
            {
                steelPlateItem[0].SetActive(false);
                ItemText[10].gameObject.SetActive(false);
            }

            if (IM.steelPlate >= 1)
            {
                steelPlateItem[0].SetActive(true);
                ItemText[10].gameObject.SetActive(true);
            }


            if (IM.steelCable >= 0)
            {
                steelCableItem[0].SetActive(false);
                ItemText[11].gameObject.SetActive(false);
            }

            if (IM.steelCable >= 1)
            {
                steelCableItem[0].SetActive(true);
                ItemText[11].gameObject.SetActive(true);
            }

            if (IM.screws >= 0)
            {
                screwsItem[0].SetActive(false);
                ItemText[12].gameObject.SetActive(false);
            }

            if (IM.screws >= 1)
            {
                screwsItem[0].SetActive(true);
                ItemText[12].gameObject.SetActive(true);
            }

            if (IM.gear >= 0)
            {
                gearItem[0].SetActive(false);
                ItemText[13].gameObject.SetActive(false);
            }

            if (IM.gear >= 1)
            {
                gearItem[0].SetActive(true);
                ItemText[13].gameObject.SetActive(true);
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
}
