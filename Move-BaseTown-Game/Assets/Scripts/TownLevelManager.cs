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

    public int pointsforlevel1 = 100;
    public int pointsforlevel2 = 200;
    public int pointsforlevel3 = 400;

    public Slider levelSlider;

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
        levelSlider.maxValue = pointsforlevel1;
    }

    void Update()
    {
        levelSlider.value = IM.townCurrentLevelPoints;
    }

    public void Level1()
    {
        levelSlider.maxValue = pointsforlevel2;
        LevelLocks[1].SetActive(true);
        LevelLocks[0].SetActive(false);
    }

    public void Level2()
    {
        levelSlider.maxValue = pointsforlevel3;
        LevelLocks[2].SetActive(true);
        LevelLocks[1].SetActive(false);
    }

    public void Level3()
    {
    }
}
