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
    public ParticleSystem confetti;

    ItemManager IM;
    TownLevelManager TLM;
    public GameObject mainManger;

    public GameObject[] Pages;
    public GameObject[] LevelSidebar;
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
        CostText[0].text = "Steel Rod: " + IM.steelRod + " / " + "2" + " ";
        CostText[1].text = "Steel Beam: " + IM.steelbeam + " / " + "4" + " ";
        CostText[2].text = "Steel Plate: " + IM.steelPlate + " / " + "2" + " ";
        CostText[3].text = "Screws: " + IM.screws + " / " + "4" + " ";
        CostText[4].text = "Gear: " + IM.gear + " / " + "2" + " ";

        CostText[5].text = "Steel Rod: " + IM.steelRod + " / " + "4" + " ";
        CostText[6].text = "Steel Beam: " + IM.steelbeam + " / " + "6" + " ";
        CostText[7].text = "Steel Plate: " + IM.steelPlate + " / " + "4" + " ";
        CostText[8].text = "Screws: " + IM.screws + " / " + "6" + " ";
        CostText[9].text = "Gear: " + IM.gear + " / " + "4" + " ";

        CostText[10].text = "Steel Rod: " + IM.steelRod + " / " + "6" + " ";
        CostText[11].text = "Steel Beam: " + IM.steelbeam + " / " + "8" + " ";
        CostText[12].text = "Steel Plate: " + IM.steelPlate + " / " + "6" + " ";
        CostText[13].text = "Screws: " + IM.screws + " / " + "8" + " ";
        CostText[14].text = "Gear: " + IM.gear + " / " + "6" + " ";

        CostText[15].text = "Steel Rod: " + IM.steelRod + " / " + "8" + " ";
        CostText[16].text = "Steel Beam: " + IM.steelbeam + " / " + "10" + " ";
        CostText[17].text = "Steel Plate: " + IM.steelPlate + " / " + "8" + " ";
        CostText[18].text = "Screws: " + IM.screws + " / " + "10" + " ";
        CostText[19].text = "Gear: " + IM.gear + " / " + "8" + " ";

    }

    public void TogglePages(int indexToEnable)
    {
        for (int i = 0; i < Pages.Length; i++)
        {
            Pages[i].SetActive(indexToEnable == i);
        }
    }

    public void ToggleLevelSidebars(int indexToEnable)
    {
        for (int i = 0; i < 4; i++)
        {
            LevelSidebar[i].SetActive(indexToEnable == i);
        }
    }

    public void UpgradeTownLevel1()
    {
        if (IM.steelRod >= 2 && IM.steelbeam >= 4 &&  IM.steelPlate >= 2 && IM.screws >= 4 && IM.gear >= 2 && IM.townCurrentLevelPoints >= TLM.pointsforlevel1)
        {
            TLM.Level1();
            IM.steelRod -= 2;
            IM.steelbeam -= 4;
            IM.steelPlate -= 2;
            IM.screws -= 4;
            IM.gear -= 2;
            confetti.Play();
        }
    }
    public void UpgradeTownLevel2()
    {
        if (IM.steelRod >= 4 && IM.steelbeam >= 6 && IM.steelPlate >= 4 && IM.screws >= 6 && IM.gear >= 4 && IM.townCurrentLevelPoints >= TLM.pointsforlevel2)
        {
            TLM.Level1();
            IM.steelRod -= 4;
            IM.steelbeam -= 6;
            IM.steelPlate -= 4;
            IM.screws -= 6;
            IM.gear -= 4;
            confetti.Play();
        }
    }
    public void UpgradeTownLevel3()
    {
        if (IM.steelRod >= 6 && IM.steelbeam >= 8 &&  IM.steelPlate >= 6 && IM.screws >= 8 && IM.gear >= 6 && IM.townCurrentLevelPoints >= TLM.pointsforlevel3)
        {
            TLM.Level1();
            IM.steelRod -= 6;
            IM.steelbeam -= 8;
            IM.steelPlate -= 6;
            IM.screws -= 8;
            IM.gear -= 6;
            confetti.Play();
        }
    }
    public void UpgradeTownLevel4()
    {
        if (IM.steelRod >= 8 && IM.steelbeam >= 10 && IM.steelPlate >= 8 && IM.screws >= 10 && IM.gear >= 8 && IM.townCurrentLevelPoints >= TLM.pointsforlevel4)
        {
            TLM.Level1();
            IM.steelRod -= 8;
            IM.steelbeam -= 10;
            IM.steelPlate -= 8;
            IM.screws -= 10;
            IM.gear -= 8;
            confetti.Play();
        }
    }

}
