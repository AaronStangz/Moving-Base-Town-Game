using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TownLevelManager : MonoBehaviour
{
    ItemManager IM;
    public GameObject mainManger;
    public GameObject[] LevelLocks;
    public GameObject[] BuildingLevels;

    public int pointsforlevel1 = 100;
    public int pointsforlevel2 = 300;
    public int pointsforlevel3 = 500;

    public Slider levelSlider;
    public Slider mainlevelber;

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
        levelSlider.maxValue = pointsforlevel1;
        mainlevelber.maxValue = pointsforlevel1;
    }

    void Update()
    {
        levelSlider.value = IM.townCurrentLevelPoints;
        mainlevelber.value = IM.townCurrentLevelPoints;
    }

    public void Level1()
    {
        levelSlider.maxValue = pointsforlevel2;
        mainlevelber.maxValue = pointsforlevel2;
        LevelLocks[1].SetActive(true);
        LevelLocks[0].SetActive(false);
        BuildingLevels[1].SetActive(true);
    }

    public void Level2()
    {
        levelSlider.maxValue = pointsforlevel3;
        mainlevelber.maxValue = pointsforlevel3;
        LevelLocks[2].SetActive(true);
        LevelLocks[1].SetActive(false);
        BuildingLevels[2].SetActive(true);
    }

    public void Level3()
    {
    }
}
