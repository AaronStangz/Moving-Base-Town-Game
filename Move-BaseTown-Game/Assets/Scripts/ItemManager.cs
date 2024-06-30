using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Transform playerSpawn;
    public GameObject player;

    [Header("Villager")]
    public int villagerSlots;

    [Header("Levels")]
    public int townLevel;
    public int townCurrentLevelPoints;

    [Header("Mats")]
    public int scrapMetel;
    public int lightMetel;
    public int heavyMetel;
    public int scrapWood;
    public int lightWood;
    public int heavyWood;
    public int screws;
    public int nails;
    public int Gear;
    void Start()
    {
        BaseConsole console = gameObject.GetComponent<BaseConsole>();
        player.transform.parent = playerSpawn.transform;
    }


    void Update()
    {
        
    }
}
