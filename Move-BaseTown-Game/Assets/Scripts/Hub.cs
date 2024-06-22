using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Hub : MonoBehaviour
{
    public float useRange;
    public bool guiOpen;
    public GameObject gui;
    public GameObject playerCamera;

    ItemManager IM;
    TownLevelManager TLM;
    public GameObject mainManger;

    public GameObject[] Pages;
    public GameObject[] TownLevels;
    public TMP_Text[] CostText;

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
        TLM = mainManger.GetComponent<TownLevelManager>();
    }

    void Update()
    {
        if(guiOpen) 
        {
            UpgradeText();
        }
    }

    public void Open()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            gui.SetActive(true);
            guiOpen = true;
            Cursor.lockState = CursorLockMode.None;
            playerCamera.GetComponent<PlayerCam>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && (guiOpen == true))
        {
            gui.SetActive(false);
            guiOpen = false;
            Cursor.lockState = CursorLockMode.Locked;
            playerCamera.GetComponent<PlayerCam>().enabled = true;
        }
    }

    public void UpgradeText()
    {
        CostText[0].text = "Scrap Wood: " + IM.scrapWood + " / " + "5" + " ";
        CostText[1].text = "Scrap Metel: " + IM.scrapMetel + " / " + "10 " + " ";

        CostText[2].text = "Wood: " + IM.wood + " / " + "5" + " ";
        CostText[3].text = "Metel: " + IM.metel + " / " + "15 " + " ";

        CostText[4].text = "Wood: " + IM.scrapWood + " / " + "20" + " ";
        CostText[5].text = "Metel: " + IM.scrapMetel + " / " + "40 " + " ";
    }

    public void TogglePages(int indexToEnable)
    {
        for (int i = 0; i < Pages.Length; i++)
        {
            Pages[i].SetActive(indexToEnable == i);
        }
    }

    public void ToggleTownLevels(int indexToEnable)
    {
        for (int i = 0; i < Pages.Length; i++)
        {
            TownLevels[i].SetActive(indexToEnable == i);
        }
    }

    public void UpgradeTownLevel1()
    {
        if (IM.scrapWood >= 5 && IM.scrapMetel >= 10 && IM.townCurrentLevelPoints >= TLM.pointsforlevel1)
        {
            TLM.Level1();
            IM.scrapWood -= 5;
            IM.scrapMetel -= 10;
        }
    }
    public void UpgradeTownLevel2()
    {
        if (IM.wood >= 5 && IM.metel >= 15 && IM.townCurrentLevelPoints >= TLM.pointsforlevel2)
        {
            TLM.Level2();
            IM.wood -= 5;
            IM.metel -= 15;
        }
    }
    public void UpgradeTownLevel3()
    {
        if (IM.wood >= 20 && IM.metel >= 40 && IM.townCurrentLevelPoints >= TLM.pointsforlevel3)
        {
            TLM.Level3();
            IM.wood -= 20;
            IM.metel -= 40;
        }
    }

}
