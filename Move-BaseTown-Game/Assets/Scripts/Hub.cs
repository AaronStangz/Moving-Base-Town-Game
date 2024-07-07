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
            if(Input.GetKey(KeyCode.Escape)) 
            {
                gui.SetActive(false);
                guiOpen = false;
                Cursor.lockState = CursorLockMode.Locked;
                playerCamera.GetComponent<PlayerCam>().enabled = true;
            }
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
    }

    public void UpgradeText()
    {
        CostText[0].text = "Light Metel: " + IM.lightMetel + " / " + "5" + " ";
        CostText[1].text = "Heavy Metel: " + IM.heavyMetel + " / " + "10" + " ";
        CostText[2].text = "Light Wood: " + IM.lightWood + " / " + "4" + " ";

        CostText[3].text = "Light Metel: " + IM.lightMetel + " / " + "10" + " ";
        CostText[4].text = "Heavy Metel: " + IM.heavyMetel + " / " + "15" + " ";
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
        if (IM.lightMetel >= 5 && IM.heavyMetel >= 10 && IM.lightWood >= 5)
        {
            TLM.Level1();
            IM.lightMetel -= 5;
            IM.heavyMetel -= 10;
            IM.lightWood -= 5;
        }
    }
    public void UpgradeTownLevel2()
    {
        if (IM.lightMetel >= 10 && IM.heavyMetel >= 15 && IM.townCurrentLevelPoints >= TLM.pointsforlevel2)
        {
            TLM.Level2();
            IM.lightMetel -= 10;
            IM.heavyMetel -= 15;
        }
    }
    public void UpgradeTownLevel3()
    {
        if (IM.lightMetel >= 20 && IM.heavyMetel >= 40 && IM.townCurrentLevelPoints >= TLM.pointsforlevel3)
        {
            TLM.Level3();
            IM.lightMetel -= 20;
            IM.heavyMetel -= 40;
        }
    }

}
